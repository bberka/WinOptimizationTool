namespace WinOptimizationTool.Functions.Registery.Security;

public class DownloadBlocking : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Policies\Attachments","SaveZoneInformation",1),
		};
		return list.ToSingleResult("DisableDownloadBlocking");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "SaveZoneInformation"),
		};
		return list.ToSingleResult("EnableDownloadBlocking");
	}
}