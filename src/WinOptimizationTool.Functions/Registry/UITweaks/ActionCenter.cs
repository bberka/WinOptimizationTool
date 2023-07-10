namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ActionCenter : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Policies\Microsoft\Windows\Explorer","DisableNotificationCenter",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\PushNotifications","ToastEnabled",0),
		};
		return list.CombineAll("DisableActionCenter");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Policies\Microsoft\Windows\Explorer", "DisableNotificationCenter"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\PushNotifications", "ToastEnabled"),
		};
		return list.CombineAll("EnableActionCenter");
	}
}
