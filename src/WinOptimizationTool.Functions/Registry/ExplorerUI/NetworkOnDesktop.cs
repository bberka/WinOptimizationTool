namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NetworkOnDesktop : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
		};
		return list.Combine(true,"ShowNetworkOnDesktop");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
		};
		return list.Combine(true,"HideNetworkFromDesktop");
	}
}
