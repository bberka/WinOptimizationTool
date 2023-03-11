namespace WinOptimizationTool.Functions.Registry.Security;

public class DEPOpt : BaseFunction
{
	public static Result SetOut()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} nx OptOut | Out-Null"),
		};
		return list.ToSingleResult("SetDEPOptOut");
	}
	public static Result SetIn()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","bcdedit /set `{current`} nx OptIn | Out-Null"),
		};
		return list.ToSingleResult("SetDEPOptIn");
	}
}
