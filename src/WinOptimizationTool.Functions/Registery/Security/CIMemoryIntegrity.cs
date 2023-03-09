namespace WinOptimizationTool.Functions.Registery.Security;

public class CIMemoryIntegrity : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\DeviceGuard\Scenarios\HypervisorEnforcedCodeIntegrity","Enabled",1),
		};
		return list.ToSingleResult("EnableCIMemoryIntegrity");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Control\DeviceGuard\Scenarios\HypervisorEnforcedCodeIntegrity", "Enabled"),
		};
		return list.ToSingleResult("DisableCIMemoryIntegrity");
	}
}