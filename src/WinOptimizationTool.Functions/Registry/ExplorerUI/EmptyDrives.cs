namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class EmptyDrives : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideDrivesWithNoMedia",0),
		};
		return list.CombineAll("ShowEmptyDrives");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideDrivesWithNoMedia"),
		};
		return list.CombineAll("HideEmptyDrives");
	}
}
