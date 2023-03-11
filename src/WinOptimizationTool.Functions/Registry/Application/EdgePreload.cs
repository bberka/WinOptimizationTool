namespace WinOptimizationTool.Functions.Registry.Application;

public class EdgePreload : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main","AllowPrelaunch",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\TabPreloader","AllowTabPreloading",0),
		};
		return list.ToSingleResult("DisableEdgePreload");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main", "AllowPrelaunch"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\TabPreloader", "AllowTabPreloading"),
		};
		return list.ToSingleResult("EnableEdgePreload");
	}
}
