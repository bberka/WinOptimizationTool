namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPEmail : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessEmail",2),
		};
		return list.Combine(true,"DisableUWPEmail");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessEmail"),
		};
		return list.Combine(true,"EnableUWPEmail");
	}
}
