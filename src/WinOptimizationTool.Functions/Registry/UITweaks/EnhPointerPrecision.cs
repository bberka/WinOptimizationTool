namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class EnhPointerPrecision : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseSpeed",@"0"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold1",@"0"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold2",@"0"),
		};
		return list.CombineAll("DisableEnhPointerPrecision");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseSpeed",@"1"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold1",@"6"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold2",@"10"),
		};
		return list.CombineAll("EnableEnhPointerPrecision");
	}
}
