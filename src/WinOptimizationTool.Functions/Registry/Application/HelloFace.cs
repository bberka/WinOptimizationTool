namespace WinOptimizationTool.Functions.Registry.Application;

public class HelloFace : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Hello.Face*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallHelloFace");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Hello.Face*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallHelloFace");
	}
}
