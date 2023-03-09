namespace WinOptimizationTool.Functions.Registery.Service;

public class AutoRestartSignOn : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableAutomaticRestartSignOn",1),
		};
		return list.ToSingleResult("DisableAutoRestartSignOn");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "DisableAutomaticRestartSignOn"),
		};
		return list.ToSingleResult("EnableAutoRestartSignOn");
	}
}