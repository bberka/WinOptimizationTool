namespace WinOptimizationTool.Functions.Registry.Security;

public class MeltdownCompatFlag : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\QualityCompat","cadca5fe-87d3-4b96-b7fb-a231484277cc",0),
		};
		return list.Combine(true,"EnableMeltdownCompatFlag");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\QualityCompat", "cadca5fe-87d3-4b96-b7fb-a231484277cc"),
		};
		return list.Combine(true,"DisableMeltdownCompatFlag");
	}
}
