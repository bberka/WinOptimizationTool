namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class Messaging : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessMessaging",2),
		};
		return list.ToSingleResult("DisableUWPMessaging");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessMessaging"),
		};
		return list.ToSingleResult("EnableUWPMessaging");
	}
}