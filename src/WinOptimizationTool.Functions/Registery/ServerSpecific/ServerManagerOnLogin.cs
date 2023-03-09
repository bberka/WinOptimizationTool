namespace WinOptimizationTool.Functions.Registery.ServerSpecific;

public class ServerManagerOnLogin : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Server\ServerManager","DoNotOpenAtLogon",1),
		};
		return list.ToSingleResult("HideServerManagerOnLogin");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Server\ServerManager", "DoNotOpenAtLogon"),
		};
		return list.ToSingleResult("ShowServerManagerOnLogin");
	}
}