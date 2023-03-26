namespace WinOptimizationTool.Functions.Registry.Network;

public class ConnectionSharing : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Network Connections","NC_ShowSharedAccessUI",0),
		};
		return list.Combine(true,"DisableConnectionSharing");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Network Connections", "NC_ShowSharedAccessUI"),
		};
		return list.Combine(true,"EnableConnectionSharing");
	}
}
