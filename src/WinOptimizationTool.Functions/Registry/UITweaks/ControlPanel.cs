namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ControlPanel : BaseFunction
{
    [DisplayName("Control Panel Set Categories")]
	public static Result SetCategories()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel", "StartupPage"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel", "AllItemsIconView"),
		};
		return list.CombineAll("SetControlPanelCategories");
	}

    [DisplayName("Control Panel Set Large Icons")]
    public static Result SetLargeIcons()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","StartupPage",1),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","AllItemsIconView",0),
        };
        return list.CombineAll("SetControlPanelLargeIcons");
    }

    [DisplayName("Control Panel Set Small Icons")]
    public static Result SetSmallIcons()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","StartupPage",1),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","AllItemsIconView",1),
        };
        return list.CombineAll("SetControlPanelSmallIcons");
    }
}
