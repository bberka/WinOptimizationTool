namespace WinOptimizationTool.Functions.Registry.Service;

public class NTFSLastAccess : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","# User Managed, Last Access Updates Disabled"),
			Result.MultipleErrors("Not Implemented","fsutil behavior set DisableLastAccess 1 | Out-Null"),
		};
		return list.Combine(true,"DisableNTFSLastAccess");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","# System Managed, Last Access Updates Enabled"),
			Result.MultipleErrors("Not Implemented","fsutil behavior set DisableLastAccess 2 | Out-Null"),
			Result.MultipleErrors("Not Implemented","# Last Access Updates Enabled"),
			Result.MultipleErrors("Not Implemented","fsutil behavior set DisableLastAccess 0 | Out-Null"),
		};
		return list.Combine(true,"EnableNTFSLastAccess");
	}
}
