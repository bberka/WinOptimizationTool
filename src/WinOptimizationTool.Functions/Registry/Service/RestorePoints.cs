namespace WinOptimizationTool.Functions.Registry.Service;

public class RestorePoints : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.Combine(true,"DisableRestorePoints");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.Combine(true,"EnableRestorePoints");
	}
}
