using System.Net.Http.Headers;
using System.Text;
using EasMe;
using EasMe.Extensions;
using EasMe.Logging;
using EasMe.Result;
using WinOptimizationTool.Core.Helpers;


namespace WinOptimizationTool.Reader;

public class FileParser
{
	private static readonly IEasLog logger = EasLogFactory.CreateLogger();
	public FileParser(string path, string outPath,string folderName)
	{
		AllLines = File.ReadAllLines(path);
		Parser = new FunctionParser(AllLines, outPath, folderName);
		OutPath = outPath;
	}

	public string[] AllLines { get; set; }
	public string OutPath { get; set; }
	public FunctionParser Parser { get; set; }
	public class FunctionParser
	{
		public FunctionParser(string[] allLines, string outPath, string folderName)
		{
			var list = ReadAndParse(allLines);
			WriteFile(list, outPath, folderName);
		}

		//private static void WriteFile(List<Function> functions, string outPath)
		//{
		//	var b = new StringBuilder();
		//	const string line1 = "namespace WinOptimizationTool.Functions;";
		//	const string line2 = "public class ParsedFunctions";
		//	const string line3 = "{";
		//	b.AppendLine(line1);
		//	b.AppendLine(line2);
		//	b.AppendLine(line3);
		//	foreach (var item in functions)
		//	{
		//		if(item.Lines.Count == 0) continue;
		//		b.AppendLine("	public static Result " + item.FuncName +"()");
		//		b.AppendLine("	{");
		//		b.AppendLine("		var list = new List<Result>()");
		//		b.AppendLine("		{");


		//		foreach (var code in item.Lines)
		//		{
		//			b.AppendLine("			"+ code);
		//		}

		//		b.AppendLine("		};");
		//		b.AppendLine($"		return list.ToSingleResult(\"{item.FuncName}\");");
		//		b.AppendLine("	}");
		//	}
		//	const string line4 = "}";
		//	b.AppendLine(line4);
		//	var result = b.ToString();
		//	File.WriteAllText(outPath, result);
		//}
        private static void WriteFile(List<Function> functions, string outPath, string folderName)
        {
            var grouped = functions.GroupBy(x => x.ClassName).ToList();
            foreach (var function in grouped)
            {
				if(function.Key.IsNullOrEmpty()) continue;
                var b = new StringBuilder();
                string line1 = "namespace WinOptimizationTool.Functions.Registry." + folderName + ";";
                string line2 = "public class " + function.Key + " : BaseFunction";
                const string line3 = "{";
                b.AppendLine(line1);
                b.AppendLine();
                b.AppendLine(line2);
                b.AppendLine(line3);
                foreach (var item in function)
                {
                    if (item.Lines.Count == 0) continue;
                    b.AppendLine("	public static Result " + item.FuncName.Replace(function.Key,"") + "()");
                    b.AppendLine("	{");
                    b.AppendLine("		var list = new List<Result>()");
                    b.AppendLine("		{");


                    foreach (var code in item.Lines)
                    {
                        b.AppendLine("			" + code);
                    }

                    b.AppendLine("		};");
                    b.AppendLine($"		return list.ToSingleResult(\"{item.FuncName}\");");
                    b.AppendLine("	}");
                }
                const string line5 = "}";
                b.AppendLine(line5);
                var result = b.ToString();
                var dir = Path.Combine(outPath, folderName);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var path = Path.Combine(dir, function.Key + ".cs");
                File.WriteAllText(path, result);
            }
            

        }
        private static List<Function> ReadAndParse(string[] allLines)
		{
			var functions = new List<Function>();
			bool isFuncBody = false;
			bool isIfBody = false;
			var currentFunc = new Function();
			foreach (var baseLine in allLines)
			{
				var line = baseLine.RemoveLineEndings();
				if (line.IsNullOrEmpty()) continue;
				if (line.StartsWith("Function "))
				{
					currentFunc.FuncName = line.Split(" ")[1];
					isFuncBody = true;
					continue;
				}
				if (line.StartsWith("}"))
				{
					if (isIfBody)
					{
						isIfBody = false;
						continue;
					}
					isFuncBody = false;
					functions.Add(currentFunc);
					currentFunc = new Function();
				}
				if (isFuncBody)
				{
					if (line.StartsWith("Set-ItemProperty"))
					{
						var setParse = UpdateParse.Create(line);
						if(setParse.IsFailure) continue;
						currentFunc.Lines.Add(setParse.Data.Code);
						continue;

					}
					if (line.StartsWith("Remove-ItemProperty"))
					{
						var removeParse = RemovePropParse.Create(line);
						if (removeParse.IsFailure) continue;
						currentFunc.Lines.Add(removeParse.Data.Code);
						continue;
					}
                    if (line.StartsWith("Remove-Item"))
                    {
                        var removeParse = RemoveParse.Create(line);
                        if (removeParse.IsFailure) continue;
                        currentFunc.Lines.Add(removeParse.Data.Code);
                        continue;
                    }
                    if (line.StartsWith("Enable-ScheduledTask"))
					{
						var taskName = line.GetBetween("Enable-ScheduledTask -TaskName \"", "\"");
						var code = $"TaskHelper.EnableTask(@\"{taskName}\"),";
						currentFunc.Lines.Add(code);
						continue;

					}
					if (line.StartsWith("Disable-ScheduledTask"))
					{
						var taskName = line.GetBetween("Disable-ScheduledTask -TaskName \"", "\"");
						var code = $"TaskHelper.DisableTask(@\"{taskName}\"),";
						currentFunc.Lines.Add(code);
						continue;

					}
					if (line.StartsWith("Set-Service"))
					{
						var serviceName = line.GetBetween("Set-Service \"", "\" -StartupType");
						var startupType = line.GetAfter("-StartupType ");
						var code = $"ServiceHelper.SetService(\"{serviceName}\",\"{startupType}\"),";
						currentFunc.Lines.Add(code);
						continue;

					}
					if (line.StartsWith("Start-Service"))
					{
						var serviceName = line.GetBetween("Start-Service \"", "\"");
						var code = $"ServiceHelper.StartService(\"{serviceName}\"),";
						currentFunc.Lines.Add(code);
						continue;

					}
					if (line.StartsWith("Stop-Service"))
					{
						var serviceName = line.GetBetween("Stop-Service \"", "\"");
						var code = $"ServiceHelper.StopService(\"{serviceName}\"),";
						currentFunc.Lines.Add(code);
						continue;
					}
					if (line.StartsWith("New-Item"))
					{
						//ignore
						continue;
					}
					if (line.StartsWith("If"))
					{
						isIfBody = true;
						continue;
						//ignore

					}
					if(line.StartsWith("Write-Output")) continue;
					currentFunc.Lines.Add($"Result.MultipleErrors(\"Not Implemented\",\"{line.Replace("\\","\\\\").Replace("\"", "\\\"")}\"),");
					//logger.Info(line);
				}
			}

			return functions;
		}
	}

	static string GetPathEnumValue(string mainPath)
	{
		return mainPath switch
		{
			"HKLM" => "RegistryHive.LocalMachine",
			"HKCU" => "RegistryHive.CurrentUser",
			"HKCR" => "RegistryHive.ClassesRoot",
			"HKU" => "RegistryHive.Users",
			"HKCC" => "RegistryHive.CurrentConfig",
			_ => ""
		};
	}
    
    public class Function
	{
		public string FuncName { get; set; } = "";

        public string ClassName => GetClassName(FuncName);
       
        public List<string> Lines { get; set; } = new List<string>();
        private string GetClassName( string a)
        {
            return a
                    .RemoveText("Enable")
                    .RemoveText("Disable")
                    .RemoveText("Install")
                    .RemoveText("Uninstall")
                    .RemoveText("Set")
                    .RemoveText("Unset")
                    .RemoveText("Add")
                    .RemoveText("Remove")
                    .RemoveText("High")
                    .RemoveText("Low")
                    .RemoveText("Show")
                    .RemoveText("Hide")
                    .RemoveText("Out")
                    .RemoveText("In")
                    .RemoveText("Public")
                    .RemoveText("Private")
                    .RemoveText("Local")
                    .RemoveText("Unpin")
                ;
        }

        private string GetClassName(string a, string b)
        {
            var textA = a
                    .RemoveText("Enable")
                    .RemoveText("Disable")
                    .RemoveText("Install")
                    .RemoveText("Uninstall")
                    .RemoveText("Set")
                    .RemoveText("Unset")
                    .RemoveText("Add")
                    .RemoveText("Remove")
                    .RemoveText("High")
                    .RemoveText("Low")
                    .RemoveText("Show")
                    .RemoveText("Hide")
                    .RemoveText("Out")
                    .RemoveText("In")
                    .RemoveText("Public")
                    .RemoveText("Private")
                    .RemoveText("Local")
                    .RemoveText("Unpin")
                ;
            var textB = b
                    .RemoveText("Enable")
                    .RemoveText("Disable")
                    .RemoveText("Install")
                    .RemoveText("Uninstall")
                    .RemoveText("Set")
                    .RemoveText("Unset")
                    .RemoveText("Add")
                    .RemoveText("Remove")
                    .RemoveText("High")
                    .RemoveText("Low")
                    .RemoveText("Show")
                    .RemoveText("Hide")
                    .RemoveText("Out")
                    .RemoveText("In")
                    .RemoveText("Public")
                    .RemoveText("Private")
                    .RemoveText("Local")
                    .RemoveText("Unpin")
                ;
            if (textA == textB) return textA;
            return string.Empty;
        }
    }
    public class RemoveParse
    {
        public static ResultData<RemoveParse> Create(string line)
        {
            var removeParse = new RemoveParse(line);
            return removeParse;
            try
            {
                
            }
            catch (Exception ex)
            {
                logger.Exception(ex, line);
                return Result.Warn(ex.Message);
            }
        }
        private RemoveParse(string line)
        {
            try
            {
                var split = line.Split("\"");
                var pathSplit = split[1].Split(@":\");
                var mainPath = GetPathEnumValue(pathSplit[0]);
                MainPath = mainPath;
                Path = pathSplit[1];
                Code = $"RegHelper.DeletePath({MainPath}, @\"{Path}\"),";
            }
            catch (Exception ex)
            {
                Code = $"Result.MultipleErrors(\"Not Implemented\",\"{line.Replace("\\", "\\\\").Replace("\"", "\\\"")}\"),";
                logger.Exception(ex, line);
            }
        }
        public string MainPath { get; set; }
        public string Path { get; set; }
        public string Code { get; set; }
    }
    public class RemovePropParse
	{
		public static ResultData<RemovePropParse> Create(string line)
		{
			try
			{
				var removeParse = new RemovePropParse(line);
				return removeParse;
			}
			catch (Exception ex)
			{
				logger.Exception(ex,line);
				return Result.Warn(ex.Message);
			}
		}
		private RemovePropParse(string line)
		{
			var split = line.Split("\"");
			var pathSplit = split[1].Split(@":\");
			var mainPath = GetPathEnumValue(pathSplit[0]);
			MainPath = mainPath;
			Path = pathSplit[1];
			Key = split[3];
		}
		public string MainPath { get; set; }
		public string Path { get; set; }
		public string Key { get; set; }
		public string Code => $"RegHelper.DeleteValue({MainPath}, @\"{Path}\", \"{Key}\"),";
	}
	public class UpdateParse
	{
		public static ResultData<UpdateParse> Create(string line)
		{
			try
			{
				var updateParse = new UpdateParse(line);
				return updateParse;
			}
			catch (Exception ex)
			{
				logger.Exception(ex, line);
				return Result.Warn(ex.Message);
			}
		}

		private UpdateParse(string line)
		{
			var split = line.Split("\"");
			var pathSplit = split[1].Split(@":\");
			var mainPath = GetPathEnumValue(pathSplit[0]);
			MainPath = mainPath;
			Path = pathSplit[1];
			Key = split[3];
			var rest = split[4];
			ValueType = line.GetBetween(" -Type ", " -Value").Trim();
			Value = line.GetAfter("-Value ").Trim().Replace("\"","");
			//var restSplit = rest.Split(" ");
			//ValueType = restSplit[2].Trim();
			//Value = restSplit[4].Trim().Replace("\"", "");
		}
		public string MainPath { get; set; }
		public string Path { get; set; }
		public string Key { get; set; }
		public string ValueType { get; set; }
		public string Value { get; set; }

		public string Code => ValueType switch
		{
			"String" => $"RegHelper.SetString({MainPath},@\"{Path}\",\"{Key}\",@\"{Value}\"),",
			"DWord" => $"RegHelper.SetDword({MainPath},@\"{Path}\",\"{Key}\",{Value}),",
			_ => "",
		};
	}
}