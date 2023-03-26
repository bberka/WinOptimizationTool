namespace WinOptimizationTool.Functions.Registry.Security;

public class RecoveryAndReset : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","reagentc /disable 2>&1 | Out-Null"),
		};
		return list.Combine(true,"DisableRecoveryAndReset");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","reagentc /enable 2>&1 | Out-Null"),
		};
		return list.Combine(true,"EnableRecoveryAndReset");
	}
}
