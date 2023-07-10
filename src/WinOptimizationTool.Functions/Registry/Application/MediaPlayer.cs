namespace WinOptimizationTool.Functions.Registry.Application;

public class MediaPlayer : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"WindowsMediaPlayer\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Media.WindowsMediaPlayer*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallMediaPlayer");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"WindowsMediaPlayer\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Media.WindowsMediaPlayer*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallMediaPlayer");
	}
}
