namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ExplorerQuickAccess : BaseFunction
{
	public static Result Set()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo"),
		};
		return list.ToSingleResult("SetExplorerQuickAccess");
	}
}
