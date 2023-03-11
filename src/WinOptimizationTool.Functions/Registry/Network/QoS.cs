namespace WinOptimizationTool.Functions.Registry.Network;

public class QoS : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.ToSingleResult("DisableQoS");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_pacer\""),
		};
		return list.ToSingleResult("EnableQoS");
	}
}