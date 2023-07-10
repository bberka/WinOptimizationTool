namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPCallHistory : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessCallHistory",2),
		};
		return list.CombineAll("DisableUWPCallHistory");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessCallHistory"),
		};
		return list.CombineAll("EnableUWPCallHistory");
	}
}
