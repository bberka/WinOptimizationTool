namespace WinOptimizationTool.Functions.Registry.Service;

public class AutoRestartSignOn : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableAutomaticRestartSignOn",1),
		};
		return list.CombineAll("DisableAutoRestartSignOn");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableAutomaticRestartSignOn"),
		};
		return list.CombineAll("EnableAutoRestartSignOn");
	}
}
