namespace WinOptimizationTool.Functions.Registry.Security;

public class F8BootMenu : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Legacy | Out-Null"),
		};
		return list.Combine(true,"EnableF8BootMenu");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Standard | Out-Null"),
		};
		return list.Combine(true,"DisableF8BootMenu");
	}
}
