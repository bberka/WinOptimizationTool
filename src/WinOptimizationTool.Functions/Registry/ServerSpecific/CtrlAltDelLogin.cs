namespace WinOptimizationTool.Functions.Registry.ServerSpecific;

public class CtrlAltDelLogin : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableCAD",1),
		};
		return list.ToSingleResult("DisableCtrlAltDelLogin");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableCAD",0),
		};
		return list.ToSingleResult("EnableCtrlAltDelLogin");
	}
}
