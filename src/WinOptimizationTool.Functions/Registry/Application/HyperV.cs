namespace WinOptimizationTool.Functions.Registry.Application;

public class HyperV : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Hyper-V-All\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Install-WindowsFeature -Name \"Hyper-V\" -IncludeManagementTools -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"InstallHyperV");
	}
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Hyper-V-All\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Uninstall-WindowsFeature -Name \"Hyper-V\" -IncludeManagementTools -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"UninstallHyperV");
	}
}
