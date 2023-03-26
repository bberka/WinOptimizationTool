namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ShortcutInName : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			
		};
		return list.Combine(true,"DisableShortcutInName");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "link"),
		};
		return list.Combine(true,"EnableShortcutInName");
	}
}
