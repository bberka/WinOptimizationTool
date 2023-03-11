namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ShortcutArrow : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons","29",@"%SystemRoot%\System32\imageres.dll,-1015"),
		};
		return list.ToSingleResult("HideShortcutArrow");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", "29"),
		};
		return list.ToSingleResult("ShowShortcutArrow");
	}
}
