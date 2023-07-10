namespace WinOptimizationTool.Functions.Registry.Service;

public class NTFSLastAccess : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","# User Managed, Last Access Updates Disabled"),
			Result.Error("Not Implemented","fsutil behavior set DisableLastAccess 1 | Out-Null"),
		};
		return list.CombineAll("DisableNTFSLastAccess");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","# System Managed, Last Access Updates Enabled"),
			Result.Error("Not Implemented","fsutil behavior set DisableLastAccess 2 | Out-Null"),
			Result.Error("Not Implemented","# Last Access Updates Enabled"),
			Result.Error("Not Implemented","fsutil behavior set DisableLastAccess 0 | Out-Null"),
		};
		return list.CombineAll("EnableNTFSLastAccess");
	}
}
