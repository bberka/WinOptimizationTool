namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ShareMenu : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"*\shellex\ContextMenuHandlers\ModernSharing"),
		};
		return list.CombineAll("HideShareMenu");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"*\shellex\ContextMenuHandlers\ModernSharing","(Default)",@"{e2bf9676-5f8f-435c-97eb-11607a5bedf7}"),
		};
		return list.CombineAll("ShowShareMenu");
	}
}
