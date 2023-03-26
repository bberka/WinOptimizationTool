namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class Thumbnails : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","IconsOnly",1),
		};
		return list.Combine(true,"DisableThumbnails");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","IconsOnly",0),
		};
		return list.Combine(true,"EnableThumbnails");
	}
}
