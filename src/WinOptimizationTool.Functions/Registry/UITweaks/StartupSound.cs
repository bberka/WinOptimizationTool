namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class StartupSound : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\BootAnimation","DisableStartupSound",1),
		};
		return list.Combine(true,"DisableStartupSound");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\BootAnimation","DisableStartupSound",0),
		};
		return list.Combine(true,"EnableStartupSound");
	}
}
