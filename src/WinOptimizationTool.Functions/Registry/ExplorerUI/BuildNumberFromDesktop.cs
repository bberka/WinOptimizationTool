namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class BuildNumberFromDesktop : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Desktop","PaintDesktopVersion",0),
		};
		return list.ToSingleResult("HideBuildNumberFromDesktop");
	}
}
