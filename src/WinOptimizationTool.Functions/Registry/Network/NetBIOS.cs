namespace WinOptimizationTool.Functions.Registry.Network;

public class NetBIOS : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces\Tcpip*","NetbiosOptions",2),
		};
		return list.CombineAll("DisableNetBIOS");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\services\NetBT\Parameters\Interfaces\Tcpip*","NetbiosOptions",0),
		};
		return list.CombineAll("EnableNetBIOS");
	}
}
