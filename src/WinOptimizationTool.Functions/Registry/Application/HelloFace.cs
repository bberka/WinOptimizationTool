namespace WinOptimizationTool.Functions.Registry.Application;

public class HelloFace : BaseFunction
{
	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Hello.Face*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.ToSingleResult("UninstallHelloFace");
	}
	public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"Hello.Face*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.ToSingleResult("InstallHelloFace");
	}
}
