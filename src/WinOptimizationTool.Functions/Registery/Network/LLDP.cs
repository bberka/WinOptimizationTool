namespace WinOptimizationTool.Functions.Registery.Network;

public class LLDP
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lldp\""),
		};
		return list.ToSingleResult("DisableLLDP");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lldp\""),
		};
		return list.ToSingleResult("EnableLLDP");
	}
}