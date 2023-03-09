namespace WinOptimizationTool.Functions.Registery.Network;

public class NCSIProbe : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\NetworkConnectivityStatusIndicator","NoActiveProbe",1),
		};
		return list.ToSingleResult("DisableNCSIProbe");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\NetworkConnectivityStatusIndicator", "NoActiveProbe"),
		};
		return list.ToSingleResult("EnableNCSIProbe");
	}
}