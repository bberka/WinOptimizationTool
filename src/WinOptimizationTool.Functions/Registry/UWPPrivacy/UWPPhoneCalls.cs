namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPPhoneCalls : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessPhone",2),
		};
		return list.CombineAll("DisableUWPPhoneCalls");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessPhone"),
		};
		return list.CombineAll("EnableUWPPhoneCalls");
	}
}
