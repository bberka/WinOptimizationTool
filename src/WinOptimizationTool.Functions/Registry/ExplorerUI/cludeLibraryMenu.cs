namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class cludeLibraryMenu : BaseFunction
{
	public static Result HideIncludeInLibraryMenu()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Folder\ShellEx\ContextMenuHandlers\Library Location"),
		};
		return list.ToSingleResult("HideIncludeInLibraryMenu");
	}
	public static Result ShowIncludeInLibraryMenu()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Folder\ShellEx\ContextMenuHandlers\Library Location","(Default)",@"{3dad6c5d-2167-4cae-9914-f99e41c12cfa}"),
		};
		return list.ToSingleResult("ShowIncludeInLibraryMenu");
	}
}
