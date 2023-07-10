namespace WinOptimizationTool.Functions.Registry.Security;

public class RecoveryAndReset : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","reagentc /disable 2>&1 | Out-Null"),
		};
		return list.CombineAll("DisableRecoveryAndReset");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","reagentc /enable 2>&1 | Out-Null"),
		};
		return list.CombineAll("EnableRecoveryAndReset");
	}
}
