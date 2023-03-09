namespace WinOptimizationTool.Functions.Registery.Network;

public class RemoteDesktop	: BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",0),
			Result.MultipleErrors("Not Implemented","Enable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.ToSingleResult("EnableRemoteDesktop");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Terminal Server","fDenyTSConnections",1),
			Result.MultipleErrors("Not Implemented","Disable-NetFirewallRule -Name \"RemoteDesktop*\""),
		};
		return list.ToSingleResult("DisableRemoteDesktop");
	}
}