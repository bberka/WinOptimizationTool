namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskbarSearch : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",0),
		};
		return list.CombineAll("HideTaskbarSearch");
	}
    public static Result ShowBox()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",2),
        };
        return list.CombineAll("ShowTaskbarSearchBox");
    }
    public static Result ShowIcon()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",1),
        };
        return list.CombineAll("ShowTaskbarSearchIcon");
    }
}
