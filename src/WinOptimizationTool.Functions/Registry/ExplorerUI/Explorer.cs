namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class Explorer : BaseFunction
{
	public static Result SetQuickAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo"),
		};
		return list.CombineAll("SetExplorerQuickAccess");
	}
    public static Result SetThisPC()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","LaunchTo",1),
        };
        return list.CombineAll("SetExplorerThisPC");
    }
}


