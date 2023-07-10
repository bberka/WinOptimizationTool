namespace WinOptimizationTool.Functions.Registry.Application;

public class FaxAndScan : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"FaxServicesClientPackage\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Print.Fax.Scan*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallFaxAndScan");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"FaxServicesClientPackage\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Print.Fax.Scan*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallFaxAndScan");
	}
}
