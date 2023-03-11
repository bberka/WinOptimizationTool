namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DesktopIcons : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("HideDesktopIcons");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("ShowDesktopIcons");
	}
}
