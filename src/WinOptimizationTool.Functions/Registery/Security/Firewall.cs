namespace WinOptimizationTool.Functions.Registery.Security;

public class Firewall : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile","EnableFirewall",0),
		};
		return list.ToSingleResult("DisableFirewall");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WindowsFirewall\StandardProfile", "EnableFirewall"),
		};
		return list.ToSingleResult("EnableFirewall");
	}
}