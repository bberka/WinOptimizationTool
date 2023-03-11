namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NavPaneLibraries : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Classes\CLSID\{031E4825-7B94-4dc3-B131-E946B44C8DD5}","System.IsPinnedToNameSpaceTree",1),
		};
		return list.ToSingleResult("ShowNavPaneLibraries");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Classes\CLSID\{031E4825-7B94-4dc3-B131-E946B44C8DD5}", "System.IsPinnedToNameSpaceTree"),
		};
		return list.ToSingleResult("HideNavPaneLibraries");
	}
}
