namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class SystemDarkMode : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","SystemUsesLightTheme",0),
		};
		return list.ToSingleResult("SetSystemDarkMode");
	}
    public static Result Disable()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","SystemUsesLightTheme",1),
        };
        return list.ToSingleResult("SetSystemLightMode");
    }
}
