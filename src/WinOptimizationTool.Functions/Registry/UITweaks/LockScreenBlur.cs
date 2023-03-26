namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class LockScreenBlur : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\System","DisableAcrylicBackgroundOnLogon",1),
		};
		return list.Combine(true,"DisableLockScreenBlur");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\System", "DisableAcrylicBackgroundOnLogon"),
		};
		return list.Combine(true,"EnableLockScreenBlur");
	}
}
