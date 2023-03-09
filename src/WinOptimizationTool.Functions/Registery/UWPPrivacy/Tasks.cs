namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class Tasks : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessTasks",2),
		};
		return list.ToSingleResult("DisableUWPTasks");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessTasks"),
		};
		return list.ToSingleResult("EnableUWPTasks");
	}
}