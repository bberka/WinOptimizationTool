namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class RestoreFolderWindows : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","PersistBrowsers",1),
		};
		return list.Combine(true,"EnableRestoreFldrWindows");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "PersistBrowsers"),
		};
		return list.Combine(true,"DisableRestoreFldrWindows");
	}
}
