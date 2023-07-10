namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class QuickAccess : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer","HubMode",1),
		};
		return list.CombineAll("HideQuickAccess");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "HubMode"),
		};
		return list.CombineAll("ShowQuickAccess");
	}
}
