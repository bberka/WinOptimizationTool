namespace WinOptimizationTool.Functions.Registery.Security;

public class ScriptHost : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows Script Host\Settings","Enabled",0),
		};
		return list.ToSingleResult("DisableScriptHost");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows Script Host\Settings", "Enabled"),
		};
		return list.ToSingleResult("EnableScriptHost");
	}
}