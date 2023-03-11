namespace WinOptimizationTool.Functions.Registry.Network;

public class LLMNR : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\DNSClient","EnableMulticast",0),
		};
		return list.ToSingleResult("DisableLLMNR");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\DNSClient", "EnableMulticast"),
		};
		return list.ToSingleResult("EnableLLMNR");
	}
}
