namespace WinOptimizationTool.Functions.Registry.Application;

public class AdobeFlash : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Internet Explorer","DisableFlashInIE",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Addons","FlashPlayerEnabled",0),
		};
		return list.Combine(true,"DisableAdobeFlash");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Internet Explorer", "DisableFlashInIE"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Addons", "FlashPlayerEnabled"),
		};
		return list.Combine(true,"EnableAdobeFlash");
	}
}
