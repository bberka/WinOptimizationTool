namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPRadios : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessRadios",2),
		};
		return list.Combine(true,"DisableUWPRadios");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessRadios"),
		};
		return list.Combine(true,"EnableUWPRadios");
	}
}
