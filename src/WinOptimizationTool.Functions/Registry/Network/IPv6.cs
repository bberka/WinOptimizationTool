namespace WinOptimizationTool.Functions.Registry.Network;

public class IPv6 : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.Combine(true,"DisableIPv6");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.Combine(true,"EnableIPv6");
	}
}
