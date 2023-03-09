namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class Notifications : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessNotifications",2),
		};
		return list.ToSingleResult("DisableUWPNotifications");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessNotifications"),
		};
		return list.ToSingleResult("EnableUWPNotifications");
	}
}