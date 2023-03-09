namespace WinOptimizationTool.Functions.Registery.Network;

public class MSNetClient
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_msclient\""),
		};
		return list.ToSingleResult("DisableMSNetClient");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_msclient\""),
		};
		return list.ToSingleResult("EnableMSNetClient");
	}
}