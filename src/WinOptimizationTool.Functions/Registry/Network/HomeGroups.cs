namespace WinOptimizationTool.Functions.Registry.Network;

public class HomeGroups : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("HomeGroupListener"),
			ServiceHelper.SetService("HomeGroupListener","Disabled"),
			ServiceHelper.StopService("HomeGroupProvider"),
			ServiceHelper.SetService("HomeGroupProvider","Disabled"),
		};
		return list.ToSingleResult("DisableHomeGroups");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("HomeGroupListener","Manual"),
			ServiceHelper.SetService("HomeGroupProvider","Manual"),
			ServiceHelper.StartService("HomeGroupProvider"),
		};
		return list.ToSingleResult("EnableHomeGroups");
	}
}
