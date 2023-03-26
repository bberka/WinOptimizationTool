namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ShutdownInLockScreen : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ShutdownWithoutLogon",0),
		};
		return list.Combine(true,"HideShutdownFromLockScreen");
	}
    public static Result Show()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ShutdownWithoutLogon",1),
        };
        return list.Combine(true,"ShowShutdownOnLockScreen");
    }
}
