namespace WinOptimizationTool.Functions.Registry.Application;

public class FirstLogonAnimation : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","EnableFirstLogonAnimation",0),
		};
		return list.Combine(true,"DisableFirstLogonAnimation");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableFirstLogonAnimation"),
		};
		return list.Combine(true,"EnableFirstLogonAnimation");
	}
}
