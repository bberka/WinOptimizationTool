namespace WinOptimizationTool.Functions.Registry.Security;

public class DefenderCloud : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows Defender\Spynet","SpynetReporting",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows Defender\Spynet","SubmitSamplesConsent",2),
		};
		return list.Combine(true,"DisableDefenderCloud");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows Defender\Spynet", "SpynetReporting"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows Defender\Spynet", "SubmitSamplesConsent"),
		};
		return list.Combine(true,"EnableDefenderCloud");
	}
}
