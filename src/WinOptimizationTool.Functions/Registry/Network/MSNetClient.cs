namespace WinOptimizationTool.Functions.Registry.Network;

public class MSNetClient : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_msclient\""),
		};
		return list.CombineAll("DisableMSNetClient");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_msclient\""),
		};
		return list.CombineAll("EnableMSNetClient");
	}
}
