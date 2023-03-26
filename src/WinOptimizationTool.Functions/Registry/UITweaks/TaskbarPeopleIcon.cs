namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskbarPeopleIcon : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People","PeopleBand",0),
		};
		return list.Combine(true,"HideTaskbarPeopleIcon");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People", "PeopleBand"),
		};
		return list.Combine(true,"ShowTaskbarPeopleIcon");
	}
}
