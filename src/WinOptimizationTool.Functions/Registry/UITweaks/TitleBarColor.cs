namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TitleBarColor : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","ColorPrevalence",1),
		};
		return list.Combine(true,"EnableTitleBarColor");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","ColorPrevalence",0),
		};
		return list.Combine(true,"DisableTitleBarColor");
	}
}
