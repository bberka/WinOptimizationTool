namespace WinOptimizationTool.Functions.Registry.Application;

public class NET23 : BaseFunction
{
	public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"NetFx3\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Install-WindowsFeature -Name \"NET-Framework-Core\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("InstallNET23");
	}
	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"NetFx3\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.MultipleErrors("Not Implemented","Uninstall-WindowsFeature -Name \"NET-Framework-Core\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("UninstallNET23");
	}
}