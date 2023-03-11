namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class SelectCheckboxes : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","AutoCheckSelect",0),
		};
		return list.ToSingleResult("HideSelectCheckboxes");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","AutoCheckSelect",1),
		};
		return list.ToSingleResult("ShowSelectCheckboxes");
	}
}
