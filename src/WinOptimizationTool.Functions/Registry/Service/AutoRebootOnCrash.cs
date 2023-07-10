namespace WinOptimizationTool.Functions.Registry.Service;

public class AutoRebootOnCrash : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",0),
		};
		return list.CombineAll("DisableAutoRebootOnCrash");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",1),
		};
		return list.CombineAll("EnableAutoRebootOnCrash");
	}
}
