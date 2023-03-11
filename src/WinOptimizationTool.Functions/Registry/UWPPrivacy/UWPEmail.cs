namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPEmail : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessEmail",2),
		};
		return list.ToSingleResult("DisableUWPEmail");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessEmail"),
		};
		return list.ToSingleResult("EnableUWPEmail");
	}
}
