namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NavPaneExpand : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","NavPaneExpandToCurrentFolder",1),
		};
		return list.Combine(true,"EnableNavPaneExpand");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "NavPaneExpandToCurrentFolder"),
		};
		return list.Combine(true,"DisableNavPaneExpand");
	}
}
