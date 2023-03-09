namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class DiagInfo : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsGetDiagnosticInfo",2),
		};
		return list.ToSingleResult("DisableUWPDiagInfo");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsGetDiagnosticInfo"),
		};
		return list.ToSingleResult("EnableUWPDiagInfo");
	}

}