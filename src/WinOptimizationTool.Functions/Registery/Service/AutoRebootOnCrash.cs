namespace WinOptimizationTool.Functions.Registery.Service;

public class AutoRebootOnCrash : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",0),
		};
		return list.ToSingleResult("DisableAutoRebootOnCrash");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",1),
		};
		return list.ToSingleResult("EnableAutoRebootOnCrash");
	}
}