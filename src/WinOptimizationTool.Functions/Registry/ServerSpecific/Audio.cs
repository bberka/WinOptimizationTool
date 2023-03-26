namespace WinOptimizationTool.Functions.Registry.ServerSpecific;

public class Audio : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("Audiosrv","Automatic"),
			ServiceHelper.StartService("Audiosrv"),
		};
		return list.Combine(true,"EnableAudio");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("Audiosrv"),
			ServiceHelper.SetService("Audiosrv","Manual"),
		};
		return list.Combine(true,"DisableAudio");
	}
}
