namespace WinOptimizationTool.Functions.Registry.Network;

public class SMBServer : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-SmbServerConfiguration -EnableSMB1Protocol $false -Force"),
			Result.Error("Not Implemented","Set-SmbServerConfiguration -EnableSMB2Protocol $false -Force"),
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_server\""),
		};
		return list.CombineAll("DisableSMBServer");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-SmbServerConfiguration -EnableSMB2Protocol $true -Force"),
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_server\""),
		};
		return list.CombineAll("EnableSMBServer");
	}
}
