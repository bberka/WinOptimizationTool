namespace WinOptimizationTool.Functions.Registry.Security;

public class BootRecovery : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootStatusPolicy IgnoreAllFailures | Out-Null"),
		};
		return list.Combine(true,"DisableBootRecovery");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /deletevalue `{current`} BootStatusPolicy | Out-Null"),
		};
		return list.Combine(true,"EnableBootRecovery");
	}
}
