namespace WinOptimizationTool.Functions.Registry.Application;

public class InternetExplorer : BaseFunction
{
    [NotImplemented]
    public static Result UninstallIn()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -like \"Internet-Explorer-Optional*\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Browser.InternetExplorer*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallInternetExplorer");
	}
    [NotImplemented]
    public static Result InstallIn()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -like \"Internet-Explorer-Optional*\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Browser.InternetExplorer*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallInternetExplorer");
	}
}
