namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class SearchInAppStore : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","NoUseStoreOpenWith",1),
		};
		return list.ToSingleResult("DisableSearchAppInStore");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "NoUseStoreOpenWith"),
		};
		return list.ToSingleResult("EnableSearchAppInStore");
	}
}
