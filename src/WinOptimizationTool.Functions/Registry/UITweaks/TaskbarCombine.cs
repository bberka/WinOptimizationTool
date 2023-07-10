namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskbarCombine : BaseFunction
{
	public static Result Always()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarGlomLevel"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "MMTaskbarGlomLevel"),
		};
		return list.CombineAll("SetTaskbarCombineAlways");
	}
    public static Result Never()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarGlomLevel",2),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","MMTaskbarGlomLevel",2),
        };
        return list.CombineAll("SetTaskbarCombineNever");
    }
    public static Result WhenFull()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarGlomLevel",1),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","MMTaskbarGlomLevel",1),
        };
        return list.CombineAll("SetTaskbarCombineWhenFull");
    }
}
