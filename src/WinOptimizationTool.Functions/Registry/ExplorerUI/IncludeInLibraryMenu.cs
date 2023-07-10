namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class IncludeInLibraryMenu : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Folder\ShellEx\ContextMenuHandlers\Library Location"),
		};
		return list.CombineAll("HideIncludeInLibraryMenu");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Folder\ShellEx\ContextMenuHandlers\Library Location","(Default)",@"{3dad6c5d-2167-4cae-9914-f99e41c12cfa}"),
		};
		return list.CombineAll("ShowIncludeInLibraryMenu");
	}
}
