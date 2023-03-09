namespace WinOptimizationTool.Functions.Registery.Privacy;

public class Sensors : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors","DisableSensors",1),
		};
		return list.ToSingleResult("DisableSensors");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", "DisableSensors"),
		};
		return list.ToSingleResult("EnableSensors");
	}
}