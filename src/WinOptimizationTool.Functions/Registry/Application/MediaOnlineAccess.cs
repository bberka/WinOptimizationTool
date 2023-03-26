namespace WinOptimizationTool.Functions.Registry.Application;

public class MediaOnlineAccess : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventCDDVDMetadataRetrieval",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventMusicFileMetadataRetrieval",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventRadioPresetsRetrieval",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WMDRM","DisableOnline",1),
		};
		return list.Combine(true,"DisableMediaOnlineAccess");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventCDDVDMetadataRetrieval"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventMusicFileMetadataRetrieval"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventRadioPresetsRetrieval"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WMDRM", "DisableOnline"),
		};
		return list.Combine(true,"EnableMediaOnlineAccess");
	}
}
