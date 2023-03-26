namespace WinOptimizationTool.Functions.Registry.Service;

public class Defragmentation : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			TaskHelper.DisableTask(@"Microsoft\Windows\Defrag\ScheduledDefrag"),
		};
		return list.Combine(true,"DisableDefragmentation");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			TaskHelper.EnableTask(@"Microsoft\Windows\Defrag\ScheduledDefrag"),
		};
		return list.Combine(true,"EnableDefragmentation");
	}
}
