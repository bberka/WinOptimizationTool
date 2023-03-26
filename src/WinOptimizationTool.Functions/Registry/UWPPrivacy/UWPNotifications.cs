namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPNotifications : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessNotifications",2),
		};
		return list.Combine(true,"DisableUWPNotifications");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessNotifications"),
		};
		return list.Combine(true,"EnableUWPNotifications");
	}
}
