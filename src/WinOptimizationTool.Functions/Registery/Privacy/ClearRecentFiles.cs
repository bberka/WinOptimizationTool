namespace WinOptimizationTool.Functions.Registery.Privacy;

public class ClearRecentFiles : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","ClearRecentDocsOnExit",1),
		};
		return list.ToSingleResult("EnableClearRecentFiles");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "ClearRecentDocsOnExit"),
		};
		return list.ToSingleResult("DisableClearRecentFiles");
	}
}