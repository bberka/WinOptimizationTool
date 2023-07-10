namespace WinOptimizationTool.Functions.Registry.Network;

public class NCSIProbe : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\NetworkConnectivityStatusIndicator","NoActiveProbe",1),
		};
		return list.CombineAll("DisableNCSIProbe");
	}

	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\NetworkConnectivityStatusIndicator", "NoActiveProbe"),
		};
		return list.CombineAll("EnableNCSIProbe");
	}
}
