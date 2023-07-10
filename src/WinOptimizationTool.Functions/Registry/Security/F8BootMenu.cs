namespace WinOptimizationTool.Functions.Registry.Security;

public class F8BootMenu : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Legacy | Out-Null"),
		};
		return list.CombineAll("EnableF8BootMenu");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","bcdedit /set `{current`} BootMenuPolicy Standard | Out-Null"),
		};
		return list.CombineAll("DisableF8BootMenu");
	}
}
