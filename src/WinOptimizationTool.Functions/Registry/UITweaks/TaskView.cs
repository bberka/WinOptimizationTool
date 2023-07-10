namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskView : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowTaskViewButton",0),
		};
		return list.CombineAll("HideTaskView");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton"),
		};
		return list.CombineAll("ShowTaskView");
	}
}
