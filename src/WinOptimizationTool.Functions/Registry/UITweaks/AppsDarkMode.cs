namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class DarkMode : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","AppsUseLightTheme",0),
		};
		return list.ToSingleResult("EnableDarkMode");
	}
    public static Result Disable()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","AppsUseLightTheme",1),
        };
        return list.ToSingleResult("DisableDarkMode");
    }
}
