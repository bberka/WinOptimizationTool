namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class SharingWizard : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SharingWizardOn",0),
		};
		return list.ToSingleResult("DisableSharingWizard");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "SharingWizardOn"),
		};
		return list.ToSingleResult("EnableSharingWizard");
	}
}
