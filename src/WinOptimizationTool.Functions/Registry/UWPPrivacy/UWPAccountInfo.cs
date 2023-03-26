namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPAccountInfo : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessAccountInfo",2),
		};
		return list.Combine(true,"DisableUWPAccountInfo");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessAccountInfo"),
		};
		return list.Combine(true,"EnableUWPAccountInfo");
	}
}
