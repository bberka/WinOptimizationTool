namespace WinOptimizationTool.Functions.Registry.Network;

public class QoS : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.CombineAll("DisableQoS");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.CombineAll("EnableQoS");
	}
}
