namespace WinOptimizationTool.Functions.Registry.Service;

public class MaintenanceWakeUp : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU","AUPowerManagement",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance","WakeUp",0),
		};
		return list.CombineAll("DisableMaintenanceWakeUp");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUPowerManagement"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "WakeUp"),
		};
		return list.CombineAll("EnableMaintenanceWakeUp");
	}
}
