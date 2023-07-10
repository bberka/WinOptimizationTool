namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ExplorerTitleFullPath : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\CabinetState","FullPath",1),
		};
		return list.CombineAll("ShowExplorerTitleFullPath");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\CabinetState", "FullPath"),
		};
		return list.CombineAll("HideExplorerTitleFullPath");
	}
}
