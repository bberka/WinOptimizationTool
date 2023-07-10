namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPOtherDevices : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsSyncWithDevices",2),
		};
		return list.CombineAll("DisableUWPOtherDevices");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsSyncWithDevices"),
		};
		return list.CombineAll("EnableUWPOtherDevices");
	}
}
