namespace WinOptimizationTool.Functions.Registry.Unpinning;

public class StartMenuTiles : BaseFunction
{
	public static Result Unpin()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-ChildItem -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CloudStore\\Store\\Cache\\DefaultAccount\" -Include \"*.group\" -Recurse | ForEach-Object {"),
			Result.Error("Not Implemented","$data = (Get-ItemProperty -Path \"$($_.PsPath)\\Current\" -Name \"Data\").Data -Join \",\""),
			Result.Error("Not Implemented","$data = $data.Substring(0, $data.IndexOf(\",0,202,30\") + 9) + \",0,202,80,0,0\""),
		};
		return list.CombineAll("UnpinStartMenuTiles");
	}
}
