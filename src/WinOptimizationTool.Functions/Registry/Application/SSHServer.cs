namespace WinOptimizationTool.Functions.Registry.Application;

public class SSHServer : BaseFunction
{
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"OpenSSH.Server*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallSSHServer");
	}
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"OpenSSH.Server*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallSSHServer");
	}
}
