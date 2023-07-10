namespace WinOptimizationTool.Functions.Registry.Application;

public class TelnetClient : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"TelnetClient\" } | Enable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Install-WindowsFeature -Name \"Telnet-Client\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("InstallTelnetClient");
	}
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsOptionalFeature -Online | Where-Object { $_.FeatureName -eq \"TelnetClient\" } | Disable-WindowsOptionalFeature -Online -NoRestart -WarningAction SilentlyContinue | Out-Null"),
			Result.Error("Not Implemented","Uninstall-WindowsFeature -Name \"Telnet-Client\" -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.CombineAll("UninstallTelnetClient");
	}
}
