namespace WinOptimizationTool.Functions.Registry.Application;

public class LinuxSubsystem : BaseFunction
{
	public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Windows-Subsystem-Linux\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("InstallLinuxSubsystem");
	}
	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"Microsoft-Windows-Subsystem-Linux\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("UninstallLinuxSubsystem");
	}
}
