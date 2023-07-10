namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NavPaneExpand : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","NavPaneExpandToCurrentFolder",1),
		};
		return list.CombineAll("EnableNavPaneExpand");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "NavPaneExpandToCurrentFolder"),
		};
		return list.CombineAll("DisableNavPaneExpand");
	}
}
