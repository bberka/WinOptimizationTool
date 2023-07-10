namespace WinOptimizationTool.Functions.Registry.Service;

public class SleepTimeout : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","powercfg /X monitor-timeout-ac 0"),
			Result.Error("Not Implemented","powercfg /X monitor-timeout-dc 0"),
			Result.Error("Not Implemented","powercfg /X standby-timeout-ac 0"),
			Result.Error("Not Implemented","powercfg /X standby-timeout-dc 0"),
		};
		return list.CombineAll("DisableSleepTimeout");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","powercfg /X monitor-timeout-ac 10"),
			Result.Error("Not Implemented","powercfg /X monitor-timeout-dc 5"),
			Result.Error("Not Implemented","powercfg /X standby-timeout-ac 30"),
			Result.Error("Not Implemented","powercfg /X standby-timeout-dc 15"),
		};
		return list.CombineAll("EnableSleepTimeout");
	}
}
