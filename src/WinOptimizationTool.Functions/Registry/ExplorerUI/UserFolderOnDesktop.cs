namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class UserFolderOnDesktop : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{59031a47-3f72-44a7-89c5-5595fe6b30ee}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{59031a47-3f72-44a7-89c5-5595fe6b30ee}",0),
		};
		return list.ToSingleResult("ShowUserFolderOnDesktop");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{59031a47-3f72-44a7-89c5-5595fe6b30ee}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{59031a47-3f72-44a7-89c5-5595fe6b30ee}"),
		};
		return list.ToSingleResult("HideUserFolderFromDesktop");
	}
}
