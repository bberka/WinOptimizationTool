namespace WinOptimizationTool.Functions.Registry.Application;

public class FaxAndScan : BaseFunction
{
	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"FaxServicesClientPackage\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Print.Fax.Scan*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.ToSingleResult("UninstallFaxAndScan");
	}
	public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"FaxServicesClientPackage\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Print.Fax.Scan*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.ToSingleResult("InstallFaxAndScan");
	}
}
