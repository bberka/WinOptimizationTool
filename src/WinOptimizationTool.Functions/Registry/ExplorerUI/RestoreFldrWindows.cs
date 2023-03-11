namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class RestoreFldrWindows : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","PersistBrowsers",1),
		};
		return list.ToSingleResult("EnableRestoreFldrWindows");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "PersistBrowsers"),
		};
		return list.ToSingleResult("DisableRestoreFldrWindows");
	}
}
