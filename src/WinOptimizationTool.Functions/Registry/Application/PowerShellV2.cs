namespace WinOptimizationTool.Functions.Registry.Application;

public class PowerShellV2 : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"MicrosoftWindowsPowerShellV2Root\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Uninstall-WindowsFeature -Name \"PowerShell-V2\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("UninstallPowerShellV2");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"MicrosoftWindowsPowerShellV2Root\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Install-WindowsFeature -Name \"PowerShell-V2\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("InstallPowerShellV2");
	}
}
