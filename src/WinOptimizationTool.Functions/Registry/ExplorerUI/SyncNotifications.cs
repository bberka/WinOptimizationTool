namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class SyncNotifications : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSyncProviderNotifications",0),
		};
		return list.ToSingleResult("HideSyncNotifications");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSyncProviderNotifications",1),
		};
		return list.ToSingleResult("ShowSyncNotifications");
	}
}
