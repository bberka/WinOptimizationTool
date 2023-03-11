namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class HiddenFiles : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","Hidden",1),
		};
		return list.ToSingleResult("ShowHiddenFiles");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","Hidden",2),
		};
		return list.ToSingleResult("HideHiddenFiles");
	}
}
