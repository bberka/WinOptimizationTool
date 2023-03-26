namespace WinOptimizationTool.Functions.Registry.Security;

public class Firewall : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile","EnableFirewall",0),
		};
		return list.Combine(true,"DisableFirewall");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile", "EnableFirewall"),
		};
		return list.Combine(true,"EnableFirewall");
	}
}
