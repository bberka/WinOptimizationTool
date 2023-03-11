namespace WinOptimizationTool.Functions.Registry.Privacy;

public class WAPPush : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("dmwappushservice"),
			ServiceHelper.SetService("dmwappushservice","Disabled"),
		};
		return list.ToSingleResult("DisableWAPPush");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("dmwappushservice","Automatic"),
			ServiceHelper.StartService("dmwappushservice"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Services\dmwappushservice","DelayedAutoStart",1),
		};
		return list.ToSingleResult("EnableWAPPush");
	}
}
