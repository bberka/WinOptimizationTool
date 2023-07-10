namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class GiveAccessToMenu : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"*\shellex\ContextMenuHandlers\Sharing"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Directory\Background\shellex\ContextMenuHandlers\Sharing"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Directory\shellex\ContextMenuHandlers\Sharing"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Drive\shellex\ContextMenuHandlers\Sharing"),
		};
		return list.CombineAll("HideGiveAccessToMenu");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"*\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Directory\Background\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Directory\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Drive\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
		};
		return list.CombineAll("ShowGiveAccessToMenu");
	}
}
