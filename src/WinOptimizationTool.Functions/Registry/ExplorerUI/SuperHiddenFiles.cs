namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class SuperHiddenFiles : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSuperHidden",1),
		};
		return list.CombineAll("ShowSuperHiddenFiles");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSuperHidden",0),
		};
		return list.CombineAll("HideSuperHiddenFiles");
	}
}
