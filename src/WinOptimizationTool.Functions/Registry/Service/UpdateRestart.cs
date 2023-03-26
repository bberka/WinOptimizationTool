namespace WinOptimizationTool.Functions.Registry.Service;

public class UpdateRestart : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\MusNotification.exe","Debugger",@"cmd.exe"),
		};
		return list.Combine(true,"DisableUpdateRestart");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\MusNotification.exe", "Debugger"),
		};
		return list.Combine(true,"EnableUpdateRestart");
	}
}
