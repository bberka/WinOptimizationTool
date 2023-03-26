namespace WinOptimizationTool.Functions.Registry.ServerSpecific;

public class ShutdownTracker : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\Reliability","ShutdownReasonOn",0),
		};
		return list.Combine(true,"DisableShutdownTracker");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\Reliability", "ShutdownReasonOn"),
		};
		return list.Combine(true,"EnableShutdownTracker");
	}
}
