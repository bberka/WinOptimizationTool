namespace WinOptimizationTool.Functions.Registery.Service;

public class UpdateMSRT : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MRT","DontOfferThroughWUAU",1),
		};
		return list.ToSingleResult("DisableUpdateMSRT");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MRT", "DontOfferThroughWUAU"),
		};
		return list.ToSingleResult("EnableUpdateMSRT");
	}
}