namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPDiagInfo : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsGetDiagnosticInfo",2),
		};
		return list.CombineAll("DisableUWPDiagInfo");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsGetDiagnosticInfo"),
		};
		return list.CombineAll("EnableUWPDiagInfo");
	}
}
