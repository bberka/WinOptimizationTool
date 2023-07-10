namespace WinOptimizationTool.Functions.Registry.Privacy;

public class MapUpdates : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\Maps","AutoUpdateEnabled",0),
		};
		return list.CombineAll("DisableMapUpdates");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\Maps", "AutoUpdateEnabled"),
		};
		return list.CombineAll("EnableMapUpdates");
	}
}
