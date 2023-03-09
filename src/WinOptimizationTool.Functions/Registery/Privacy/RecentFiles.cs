namespace WinOptimizationTool.Functions.Registery.Privacy;

public class RecentFiles : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoRecentDocsHistory",1),
		};
		return list.ToSingleResult("DisableRecentFiles");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecentDocsHistory"),
		};
		return list.ToSingleResult("EnableRecentFiles");
	}
}