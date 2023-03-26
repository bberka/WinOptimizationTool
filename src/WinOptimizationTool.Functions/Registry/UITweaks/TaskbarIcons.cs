namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskbarIcons : BaseFunction
{
	public static Result ShowSmall()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarSmallIcons",1),
		};
		return list.Combine(true,"ShowSmallTaskbarIcons");
	}
    public static Result ShowLarge()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSmallIcons"),
        };
        return list.Combine(true,"ShowLargeTaskbarIcons");
    }
}
