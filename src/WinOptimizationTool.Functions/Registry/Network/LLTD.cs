namespace WinOptimizationTool.Functions.Registry.Network;

public class LLTD : BaseFunction
{
    [NotImplemented]

    public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.Error("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.CombineAll("DisableLLTD");
	}
    [NotImplemented]

    public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.Error("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.CombineAll("EnableLLTD");
	}
}
