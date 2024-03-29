namespace WinOptimizationTool.Functions.Registry.Application;

public class WindowsStore : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-AppxPackage \"Microsoft.DesktopAppInstaller\" | Remove-AppxPackage"),
			Result.Error("Not Implemented","Get-AppxPackage \"Microsoft.Services.Store.Engagement\" | Remove-AppxPackage"),
			Result.Error("Not Implemented","Get-AppxPackage \"Microsoft.StorePurchaseApp\" | Remove-AppxPackage"),
			Result.Error("Not Implemented","Get-AppxPackage \"Microsoft.WindowsStore\" | Remove-AppxPackage"),
		};
		return list.CombineAll("UninstallWindowsStore");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.DesktopAppInstaller\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.Services.Store.Engagement\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.StorePurchaseApp\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
			Result.Error("Not Implemented","Get-AppxPackage -AllUsers \"Microsoft.WindowsStore\" | ForEach-Object {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}"),
		};
		return list.CombineAll("InstallWindowsStore");
	}
}
