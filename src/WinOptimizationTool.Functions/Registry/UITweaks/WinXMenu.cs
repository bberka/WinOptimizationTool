namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class WinXMenu : BaseFunction
{
	public static Result SetCmd()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DontUsePowerShellOnWinX"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DontUsePowerShellOnWinX",1),
		};
		return list.ToSingleResult("SetWinXMenuCmd");
	}
    public static Result SetPowerShell()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DontUsePowerShellOnWinX",0),
            RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DontUsePowerShellOnWinX"),
        };
        return list.ToSingleResult("SetWinXMenuPowerShell");
    }
}
