namespace WinOptimizationTool.Functions.Registry.Security;

public class BootRecovery : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","bcdedit /set `{current`} BootStatusPolicy IgnoreAllFailures | Out-Null"),
		};
		return list.CombineAll("DisableBootRecovery");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","bcdedit /deletevalue `{current`} BootStatusPolicy | Out-Null"),
		};
		return list.CombineAll("EnableBootRecovery");
	}
}
