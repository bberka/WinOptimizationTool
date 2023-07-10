namespace WinOptimizationTool.Functions.Registry.Application;

public class NET23 : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"NetFx3\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Install-WindowsFeature -Name \"NET-Framework-Core\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("InstallNET23");
	}
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"NetFx3\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Uninstall-WindowsFeature -Name \"NET-Framework-Core\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("UninstallNET23");
	}
}
