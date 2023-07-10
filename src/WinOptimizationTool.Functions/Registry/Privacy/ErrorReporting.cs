namespace WinOptimizationTool.Functions.Registry.Privacy;

public class ErrorReporting : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\Windows Error Reporting","Disabled",1),
			TaskHelper.DisableTask(@"Microsoft\Windows\Windows Error Reporting\QueueReporting"),
		};
		return list.CombineAll("DisableErrorReporting");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\Windows Error Reporting", "Disabled"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Windows Error Reporting\QueueReporting"),
		};
		return list.CombineAll("EnableErrorReporting");
	}
}
