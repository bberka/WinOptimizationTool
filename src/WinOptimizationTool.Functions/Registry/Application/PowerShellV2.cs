namespace WinOptimizationTool.Functions.Registry.Application;

public class PowerShellV2 : BaseFunction
{
	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"MicrosoftWindowsPowerShellV2Root\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Uninstall-WindowsFeature -Name \"PowerShell-V2\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("UninstallPowerShellV2");
	}
	public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"MicrosoftWindowsPowerShellV2Root\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Install-WindowsFeature -Name \"PowerShell-V2\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("InstallPowerShellV2");
	}
}
