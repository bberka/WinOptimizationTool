namespace WinOptimizationTool.Functions.Registery.Security;

public class BootRecovery : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootStatusPolicy IgnoreAllFailures | Out-Null"),
		};
		return list.ToSingleResult("DisableBootRecovery");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /deletevalue `{current`} BootStatusPolicy | Out-Null"),
		};
		return list.ToSingleResult("EnableBootRecovery");
	}
}