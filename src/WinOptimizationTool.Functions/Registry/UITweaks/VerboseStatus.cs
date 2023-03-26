namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class VerboseStatus : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"Software\Microsoft\Windows\CurrentVersion\Policies\System","VerboseStatus",1),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", "VerboseStatus"),
		};
		return list.Combine(true,"EnableVerboseStatus");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", "VerboseStatus"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"Software\Microsoft\Windows\CurrentVersion\Policies\System","VerboseStatus",0),
		};
		return list.Combine(true,"DisableVerboseStatus");
	}
}
