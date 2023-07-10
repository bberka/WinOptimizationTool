namespace WinOptimizationTool.Functions.Registry.Network;

public class RemoteDesktop : BaseFunction
{
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",0),
			Result.Error("Not Implemented","Enable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.CombineAll("EnableRemoteDesktop");
	}
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",1),
			Result.Error("Not Implemented","Disable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.CombineAll("DisableRemoteDesktop");
	}
}
