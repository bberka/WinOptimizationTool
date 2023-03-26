namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPContacts : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessContacts",2),
		};
		return list.Combine(true,"DisableUWPContacts");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessContacts"),
		};
		return list.Combine(true,"EnableUWPContacts");
	}
}
