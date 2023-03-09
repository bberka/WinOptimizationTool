namespace WinOptimizationTool.Functions.Registery.Service;

public class RestorePoints : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.ToSingleResult("DisableRestorePoints");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-ComputerRestore -Drive \"$env:SYSTEMDRIVE\""),
		};
		return list.ToSingleResult("EnableRestorePoints");
	}
}