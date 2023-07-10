namespace WinOptimizationTool.Functions.Registry.Application;

public class HyperV : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Hyper-V-All\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Install-WindowsFeature -Name \"Hyper-V\" -IncludeManagementTools -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("InstallHyperV");
	}
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Hyper-V-All\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Uninstall-WindowsFeature -Name \"Hyper-V\" -IncludeManagementTools -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("UninstallHyperV");
	}
}
