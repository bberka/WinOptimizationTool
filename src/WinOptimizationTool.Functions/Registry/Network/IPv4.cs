namespace WinOptimizationTool.Functions.Registry.Network;

public class IPv4 : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip\""),
		};
		return list.Combine(true,"DisableIPv4");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip\""),
		};
		return list.Combine(true,"EnableIPv4");
	}
}
