namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskbarSearch : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",0),
		};
		return list.Combine(true,"HideTaskbarSearch");
	}
    public static Result ShowBox()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",2),
        };
        return list.Combine(true,"ShowTaskbarSearchBox");
    }
    public static Result ShowIcon()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",1),
        };
        return list.Combine(true,"ShowTaskbarSearchIcon");
    }
}
