namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TrayIcons : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoAutoTrayNotify",1),
		};
		return list.ToSingleResult("ShowTrayIcons");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoAutoTrayNotify"),
		};
		return list.ToSingleResult("HideTrayIcons");
	}
}
