namespace WinOptimizationTool.Functions.Registry.Privacy;

public class Cortana : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Personalization\Settings","AcceptedPrivacyPolicy",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\InputPersonalization","RestrictImplicitTextCollection",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\InputPersonalization","RestrictImplicitInkCollection",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\InputPersonalization\TrainedDataStore","HarvestContacts",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowCortanaButton",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\PolicyManager\default\Experience\AllowCortana","Value",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Windows Search","AllowCortana",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\InputPersonalization","AllowInputPersonalization",0),
			Result.Error("Not Implemented","Get-AppxPackage \"Microsoft.549981C3F5F10\" | Remove-AppxPackage"),
		};
		return list.CombineAll("DisableCortana");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Personalization\Settings", "AcceptedPrivacyPolicy"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\InputPersonalization","RestrictImplicitTextCollection",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\InputPersonalization","RestrictImplicitInkCollection",0),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\InputPersonalization\TrainedDataStore", "HarvestContacts"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowCortanaButton",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\PolicyManager\default\Experience\AllowCortana","Value",1),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\InputPersonalization", "AllowInputPersonalization"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.549981C3F5F10\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
		};
		return list.CombineAll("EnableCortana");
	}
}
