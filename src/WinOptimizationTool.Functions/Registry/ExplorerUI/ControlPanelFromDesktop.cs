namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ControlPanelFromDesktop : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
		};
		return list.ToSingleResult("HideControlPanelFromDesktop");
	}
}
