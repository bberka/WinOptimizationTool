namespace WinOptimizationTool.Functions.Registry.Application;

public class IEFirstRun : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Internet Explorer\Main","DisableFirstRunCustomize",1),
		};
		return list.CombineAll("DisableIEFirstRun");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Internet Explorer\Main", "DisableFirstRunCustomize"),
		};
		return list.CombineAll("EnableIEFirstRun");
	}
}
