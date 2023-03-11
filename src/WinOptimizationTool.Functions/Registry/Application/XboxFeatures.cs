namespace WinOptimizationTool.Functions.Registry.Application;

public class XboxFeatures : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.XboxApp\" | Remove-AppxPackage"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.XboxIdentityProvider\" | Remove-AppxPackage -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.XboxSpeechToTextOverlay\" | Remove-AppxPackage"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.XboxGameOverlay\" | Remove-AppxPackage"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.XboxGamingOverlay\" | Remove-AppxPackage"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage \"Microsoft.Xbox.TCUI\" | Remove-AppxPackage"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\GameBar","AutoGameModeEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_Enabled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\GameDVR","AllowGameDVR",0),
		};
		return list.ToSingleResult("DisableXboxFeatures");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.XboxApp\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.XboxIdentityProvider\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.XboxSpeechToTextOverlay\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.XboxGameOverlay\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.XboxGamingOverlay\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.MultipleErrors("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.Xbox.TCUI\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\GameBar", "AutoGameModeEnabled"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_Enabled",1),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\GameDVR", "AllowGameDVR"),
		};
		return list.ToSingleResult("EnableXboxFeatures");
	}
}
