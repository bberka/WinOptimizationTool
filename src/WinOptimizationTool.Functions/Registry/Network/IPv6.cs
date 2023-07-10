namespace WinOptimizationTool.Functions.Registry.Network;

public class IPv6 : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.CombineAll("DisableIPv6");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.CombineAll("EnableIPv6");
	}
}
