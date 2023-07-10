namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class BuildNumberOnDesktop : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Desktop","PaintDesktopVersion",1),
		};
		return list.CombineAll("ShowBuildNumberOnDesktop");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Desktop","PaintDesktopVersion",0),
		};
		return list.CombineAll("HideBuildNumberFromDesktop");
	}
}
