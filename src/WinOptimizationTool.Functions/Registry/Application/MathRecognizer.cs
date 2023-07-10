namespace WinOptimizationTool.Functions.Registry.Application;

public class MathRecognizer : BaseFunction
{
    [NotImplemented]
    public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"MathRecognizer*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("UninstallMathRecognizer");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"MathRecognizer*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("InstallMathRecognizer");
	}
}
