namespace WinOptimizationTool.Functions.Registry.Network;

public class QoS : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.Combine(true,"DisableQoS");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.Combine(true,"EnableQoS");
	}
}
