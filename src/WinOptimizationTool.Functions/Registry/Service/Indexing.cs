namespace WinOptimizationTool.Functions.Registry.Service;

public class Indexing : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("WSearch"),
			ServiceHelper.SetService("WSearch","Disabled"),
		};
		return list.CombineAll("DisableIndexing");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("WSearch","Automatic"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Services\WSearch","DelayedAutoStart",1),
			ServiceHelper.StartService("WSearch"),
		};
		return list.CombineAll("EnableIndexing");
	}
}
