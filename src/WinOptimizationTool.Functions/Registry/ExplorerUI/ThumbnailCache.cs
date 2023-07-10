namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ThumbnailCache : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisableThumbnailCache",1),
		};
		return list.CombineAll("DisableThumbnailCache");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache"),
		};
		return list.CombineAll("EnableThumbnailCache");
	}
}
