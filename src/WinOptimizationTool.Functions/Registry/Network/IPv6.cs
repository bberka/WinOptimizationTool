namespace WinOptimizationTool.Functions.Registry.Network;

public class IPv6 : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.ToSingleResult("DisableIPv6");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip6\""),
		};
		return list.ToSingleResult("EnableIPv6");
	}
}
