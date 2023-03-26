namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ShareMenu : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"*\shellex\ContextMenuHandlers\ModernSharing"),
		};
		return list.Combine(true,"HideShareMenu");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"*\shellex\ContextMenuHandlers\ModernSharing","(Default)",@"{e2bf9676-5f8f-435c-97eb-11607a5bedf7}"),
		};
		return list.Combine(true,"ShowShareMenu");
	}
}
