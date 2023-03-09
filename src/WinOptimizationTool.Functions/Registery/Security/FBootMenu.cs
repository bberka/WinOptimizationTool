namespace WinOptimizationTool.Functions.Registery.Security;

public class FBootMenu : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Legacy | Out-Null"),
		};
		return list.ToSingleResult("EnableF8BootMenu");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Standard | Out-Null"),
		};
		return list.ToSingleResult("DisableF8BootMenu");
	}
}