namespace WinOptimizationTool.Functions.Registry.Service;

public class Autorun : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoDriveTypeAutoRun",255),
		};
		return list.Combine(true,"DisableAutorun");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoDriveTypeAutoRun"),
		};
		return list.Combine(true,"EnableAutorun");
	}
}
