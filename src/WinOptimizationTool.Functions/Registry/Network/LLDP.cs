namespace WinOptimizationTool.Functions.Registry.Network;

public class LLDP : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lldp\""),
		};
		return list.CombineAll("DisableLLDP");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lldp\""),
		};
		return list.CombineAll("EnableLLDP");
	}
}
