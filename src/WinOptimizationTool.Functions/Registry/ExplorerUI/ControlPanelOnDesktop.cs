namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ControlPanelOnDesktop : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}",0),
		};
		return list.Combine(true,"ShowControlPanelOnDesktop");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
		};
		return list.Combine(true,"HideControlPanelFromDesktop");
	}
}
