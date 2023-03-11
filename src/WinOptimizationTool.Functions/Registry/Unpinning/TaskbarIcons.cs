namespace WinOptimizationTool.Functions.Registry.Unpinning;

public class TaskbarIcons : BaseFunction
{
	public static Result Unpin()
	{
		var list = new List<Result>()
		{
			
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Taskband", "FavoritesResolve"),
		};
		return list.ToSingleResult("UnpinTaskbarIcons");
	}
}
