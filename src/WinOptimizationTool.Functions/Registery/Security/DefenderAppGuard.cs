namespace WinOptimizationTool.Functions.Registery.Security;

public class DefenderAppGuard : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-WindowsOptionalFeature -online -FeatureName \"Windows-Defender-ApplicationGuard\" -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("EnableDefenderAppGuard");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-WindowsOptionalFeature -online -FeatureName \"Windows-Defender-ApplicationGuard\" -NoRestart -WarningAction SilentlyContinue | Out-Null"),
		};
		return list.ToSingleResult("DisableDefenderAppGuard");
	}
}