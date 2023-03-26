namespace WinOptimizationTool.Functions.Registry.Network;

public class SMB1 : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-SmbServerConfiguration -EnableSMB1Protocol $false -Force"),
		};
		return list.Combine(true,"DisableSMB1");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-SmbServerConfiguration -EnableSMB1Protocol $true -Force"),
		};
		return list.Combine(true,"EnableSMB1");
	}
}
