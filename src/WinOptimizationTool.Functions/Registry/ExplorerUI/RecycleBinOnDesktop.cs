namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class RecycleBinOnDesktop : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{645FF040-5081-101B-9F08-00AA002F954E}",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{645FF040-5081-101B-9F08-00AA002F954E}",1),
		};
		return list.Combine(true,"HideRecycleBinFromDesktop");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{645FF040-5081-101B-9F08-00AA002F954E}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{645FF040-5081-101B-9F08-00AA002F954E}"),
		};
		return list.Combine(true,"ShowRecycleBinOnDesktop");
	}
}
