namespace WinOptimizationTool.Functions.Registery.Service;

public class SleepButton : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowSleepOption",0),
			Result.MultipleErrors("Not Implemented","powercfg /SETACVALUEINDEX SCHEME_CURRENT SUB_BUTTONS SBUTTONACTION 0"),
			Result.MultipleErrors("Not Implemented","powercfg /SETDCVALUEINDEX SCHEME_CURRENT SUB_BUTTONS SBUTTONACTION 0"),
		};
		return list.ToSingleResult("DisableSleepButton");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowSleepOption",1),
			Result.MultipleErrors("Not Implemented","powercfg /SETACVALUEINDEX SCHEME_CURRENT SUB_BUTTONS SBUTTONACTION 1"),
			Result.MultipleErrors("Not Implemented","powercfg /SETDCVALUEINDEX SCHEME_CURRENT SUB_BUTTONS SBUTTONACTION 1"),
		};
		return list.ToSingleResult("EnableSleepButton");
	}
}