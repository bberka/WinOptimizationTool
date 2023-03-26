namespace WinOptimizationTool.Functions.Registry.Application;

public class XPSPrinter : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Printing-XPSServices-Features\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"UninstallXPSPrinter");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Printing-XPSServices-Features\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"InstallXPSPrinter");
	}
}
