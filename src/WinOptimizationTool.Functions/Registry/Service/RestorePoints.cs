namespace WinOptimizationTool.Functions.Registry.Service;

public class RestorePoints : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Disable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.CombineAll("DisableRestorePoints");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Enable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.CombineAll("EnableRestorePoints");
	}
}
