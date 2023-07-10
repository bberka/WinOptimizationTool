namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ThumbsDBOnNetwork : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisableThumbsDBOnNetworkFolders",1),
		};
		return list.CombineAll("DisableThumbsDBOnNetwork");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbsDBOnNetworkFolders"),
		};
		return list.CombineAll("EnableThumbsDBOnNetwork");
	}
}
