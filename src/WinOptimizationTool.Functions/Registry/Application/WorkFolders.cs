namespace WinOptimizationTool.Functions.Registry.Application;

public class WorkFolders : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"WorkFolders-Client\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"UninstallWorkFolders");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"WorkFolders-Client\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.Combine(true,"InstallWorkFolders");
	}
}
