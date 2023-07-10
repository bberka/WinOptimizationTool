namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class RecentlyAddedApps : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","HideRecentlyAddedApps",1),
		};
		return list.CombineAll("HideRecentlyAddedApps");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "HideRecentlyAddedApps"),
		};
		return list.CombineAll("ShowRecentlyAddedApps");
	}
}
