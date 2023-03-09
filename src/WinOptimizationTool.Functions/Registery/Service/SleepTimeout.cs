namespace WinOptimizationTool.Functions.Registery.Service;

public class SleepTimeout : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","powercfg /X monitor-timeout-ac 0"),
			Result.MultipleErrors("Not Implemented","powercfg /X monitor-timeout-dc 0"),
			Result.MultipleErrors("Not Implemented","powercfg /X standby-timeout-ac 0"),
			Result.MultipleErrors("Not Implemented","powercfg /X standby-timeout-dc 0"),
		};
		return list.ToSingleResult("DisableSleepTimeout");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","powercfg /X monitor-timeout-ac 10"),
			Result.MultipleErrors("Not Implemented","powercfg /X monitor-timeout-dc 5"),
			Result.MultipleErrors("Not Implemented","powercfg /X standby-timeout-ac 30"),
			Result.MultipleErrors("Not Implemented","powercfg /X standby-timeout-dc 15"),
		};
		return list.ToSingleResult("EnableSleepTimeout");
	}
}