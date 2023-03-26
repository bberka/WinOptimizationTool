namespace WinOptimizationTool.Functions.Registry.Service;

public class Superfetch : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("SysMain"),
			ServiceHelper.SetService("SysMain","Disabled"),
		};
		return list.Combine(true,"DisableSuperfetch");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("SysMain","Automatic"),
			ServiceHelper.StartService("SysMain"),
		};
		return list.Combine(true,"EnableSuperfetch");
	}
}
