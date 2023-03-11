namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class RecentShortcuts : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer","ShowRecent",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer","ShowFrequent",0),
		};
		return list.ToSingleResult("HideRecentShortcuts");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "ShowRecent"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "ShowFrequent"),
		};
		return list.ToSingleResult("ShowRecentShortcuts");
	}
}
