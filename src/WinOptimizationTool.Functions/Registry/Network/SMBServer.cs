namespace WinOptimizationTool.Functions.Registry.Network;

public class SMBServer : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-SmbServerConfiguration -EnableSMB1Protocol $false -Force"),
			Result.MultipleErrors("Not Implemented","Set-SmbServerConfiguration -EnableSMB2Protocol $false -Force"),
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_server\""),
		};
		return list.ToSingleResult("DisableSMBServer");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-SmbServerConfiguration -EnableSMB2Protocol $true -Force"),
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_server\""),
		};
		return list.ToSingleResult("EnableSMBServer");
	}
}
