namespace WinOptimizationTool.Functions.Registry.Service;

public class FastStartup : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",0),
		};
		return list.CombineAll("DisableFastStartup");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",1),
		};
		return list.CombineAll("EnableFastStartup");
	}
}
