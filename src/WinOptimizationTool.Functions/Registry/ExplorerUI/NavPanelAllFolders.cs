namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NavPanelAllFolders : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","NavPaneShowAllFolders",1),
		};
		return list.CombineAll("ShowNavPaneAllFolders");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "NavPaneShowAllFolders"),
		};
		return list.CombineAll("HideNavPaneAllFolders");
	}
}
