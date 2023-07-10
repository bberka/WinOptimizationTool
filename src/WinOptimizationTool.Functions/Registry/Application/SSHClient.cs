namespace WinOptimizationTool.Functions.Registry.Application;

public class SSHClient : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"OpenSSH.Client*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallSSHClient");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"OpenSSH.Client*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallSSHClient");
	}
}
