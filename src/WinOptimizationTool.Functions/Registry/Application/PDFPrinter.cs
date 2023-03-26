namespace WinOptimizationTool.Functions.Registry.Application;

public class PDFPrinter : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Printing-PrintToPDFServices-Features\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"UninstallPDFPrinter");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Printing-PrintToPDFServices-Features\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"InstallPDFPrinter");
	}
}
