namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class FolderMergeConflicts : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideMergeConflicts",0),
		};
		return list.CombineAll("ShowFolderMergeConflicts");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideMergeConflicts"),
		};
		return list.CombineAll("HideFolderMergeConflicts");
	}
}
