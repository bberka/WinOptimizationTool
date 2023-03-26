namespace WinOptimizationTool.Functions.Registry.Network;

public class RemoteDesktop : BaseFunction
{
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",0),
			Result.MultipleErrors("Not Implemented","Enable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.Combine(true,"EnableRemoteDesktop");
	}
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",1),
			Result.MultipleErrors("Not Implemented","Disable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.Combine(true,"DisableRemoteDesktop");
	}
}
