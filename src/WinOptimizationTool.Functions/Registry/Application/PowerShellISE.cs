namespace WinOptimizationTool.Functions.Registry.Application;

public class PowerShellISE : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Microsoft.Windows.PowerShell.ISE*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallPowerShellISE");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Microsoft.Windows.PowerShell.ISE*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallPowerShellISE");
	}
}
