namespace WinOptimizationTool.Functions.Registery.Network;

public class NetDevicesAutoInst : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\NcdAutoSetup\Private","AutoSetup",0),
		};
		return list.ToSingleResult("DisableNetDevicesAutoInst");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\NcdAutoSetup\Private", "AutoSetup"),
		};
		return list.ToSingleResult("EnableNetDevicesAutoInst");
	}
}