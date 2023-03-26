namespace WinOptimizationTool.Functions.Registry.Security;

public class CIMemorytegrity : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\DeviceGuard\Scenarios\HypervisorEnforcedCodeIntegrity","Enabled",1),
		};
		return list.Combine(true,"EnableCIMemoryIntegrity");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Control\DeviceGuard\Scenarios\HypervisorEnforcedCodeIntegrity", "Enabled"),
		};
		return list.Combine(true,"DisableCIMemoryIntegrity");
	}
}
