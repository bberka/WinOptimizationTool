namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPTasks : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessTasks",2),
		};
		return list.Combine(true,"DisableUWPTasks");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessTasks"),
		};
		return list.Combine(true,"EnableUWPTasks");
	}
}
