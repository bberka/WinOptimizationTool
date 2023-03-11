namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class Network : BaseFunction
{
	public static Result ShowOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
		};
		return list.ToSingleResult("ShowNetworkOnDesktop");
	}
    public static Result ShowNetworkInExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
        };
        return list.ToSingleResult("ShowNetworkInExplorer");
    }
    public static Result HideFromDesktop()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
            RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
        };
        return list.ToSingleResult("HideNetworkFromDesktop");
    }
    public static Result HideFromExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",1),
        };
        return list.ToSingleResult("HideNetworkFromExplorer");
    }
}
