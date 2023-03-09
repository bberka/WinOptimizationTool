namespace WinOptimizationTool.Functions.Registery.Privacy;

public class AppSuggestions  : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","ContentDeliveryAllowed",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","OemPreInstalledAppsEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","PreInstalledAppsEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","PreInstalledAppsEverEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SilentInstalledAppsEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-310093Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-314559Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338387Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338388Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338389Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338393Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-353694Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-353696Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-353698Enabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SystemPaneSuggestionsEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement","ScoobeSystemSettingEnabled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WindowsInkWorkspace","AllowSuggestedAppsInWindowsInkWorkspace",0),
			Result.MultipleErrors("Not Implemented","# Empty placeholder tile collection in registry cache and restart Start Menu process to reload the cache"),
			Result.MultipleErrors("Not Implemented","$key = Get-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CloudStore\\Store\\Cache\\DefaultAccount\\*windows.data.placeholdertilecollection\\Current\""),
			Result.MultipleErrors("Not Implemented","Stop-Process -Name \"ShellExperienceHost\" -Force -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("DisableAppSuggestions");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","ContentDeliveryAllowed",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","OemPreInstalledAppsEnabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","PreInstalledAppsEnabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","PreInstalledAppsEverEnabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SilentInstalledAppsEnabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338388Enabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-338389Enabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-353694Enabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SubscribedContent-353696Enabled",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager","SystemPaneSuggestionsEnabled",1),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-310093Enabled"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-314559Enabled"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338387Enabled"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338393Enabled"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-353698Enabled"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement", "ScoobeSystemSettingEnabled"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WindowsInkWorkspace", "AllowSuggestedAppsInWindowsInkWorkspace"),
		};
		return list.ToSingleResult("EnableAppSuggestions");
	}
}