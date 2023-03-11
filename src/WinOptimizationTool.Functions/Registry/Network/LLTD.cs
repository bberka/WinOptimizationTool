namespace WinOptimizationTool.Functions.Registry.Network;

public class LLTD : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.ToSingleResult("DisableLLTD");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.ToSingleResult("EnableLLTD");
	}
}
