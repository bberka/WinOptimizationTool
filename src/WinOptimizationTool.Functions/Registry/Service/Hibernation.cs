namespace WinOptimizationTool.Functions.Registry.Service;

public class Hibernation : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"System\CurrentControlSet\Control\Session Manager\Power","HibernateEnabled",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowHibernateOption",1),
			Result.MultipleErrors("Not Implemented","powercfg /HIBERNATE ON 2>&1 | Out-Null"),
		};
		return list.Combine(true,"EnableHibernation");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"System\CurrentControlSet\Control\Session Manager\Power","HibernateEnabled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowHibernateOption",0),
			Result.MultipleErrors("Not Implemented","powercfg /HIBERNATE OFF 2>&1 | Out-Null"),
		};
		return list.Combine(true,"DisableHibernation");
	}
}
