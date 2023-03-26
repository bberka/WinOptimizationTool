namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class LockScreen : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Personalization","NoLockScreen",1),
		};
		return list.Combine(true,"DisableLockScreen");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen"),
		};
		return list.Combine(true,"EnableLockScreen");
	}
}
