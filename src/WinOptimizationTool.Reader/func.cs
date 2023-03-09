using EasMe.Result;
using Microsoft.Win32;
using WinOptimizationTool.Core.Helpers;

namespace WinOptimizationTool.Functions;
public class ParsedFunctions
{
	
	public static Result SetBIOSTimeUTC()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\TimeZoneInformation","RealTimeIsUniversal",1),
		};
		return list.ToSingleResult("SetBIOSTimeUTC");
	}
	public static Result SetBIOSTimeLocal()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Control\TimeZoneInformation", "RealTimeIsUniversal"),
		};
		return list.ToSingleResult("SetBIOSTimeLocal");
	}
	public static Result EnableHibernation()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"System\CurrentControlSet\Control\Session Manager\Power","HibernateEnabled",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowHibernateOption",1),
		};
		return list.ToSingleResult("EnableHibernation");
	}
	public static Result DisableHibernation()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"System\CurrentControlSet\Control\Session Manager\Power","HibernateEnabled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowHibernateOption",0),
		};
		return list.ToSingleResult("DisableHibernation");
	}
	public static Result DisableSleepButton()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowSleepOption",0),
		};
		return list.ToSingleResult("DisableSleepButton");
	}
	public static Result EnableSleepButton()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FlyoutMenuSettings","ShowSleepOption",1),
		};
		return list.ToSingleResult("EnableSleepButton");
	}
	public static Result DisableFastStartup()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",0),
		};
		return list.ToSingleResult("DisableFastStartup");
	}
	public static Result EnableFastStartup()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",1),
		};
		return list.ToSingleResult("EnableFastStartup");
	}
	public static Result DisableAutoRebootOnCrash()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",0),
		};
		return list.ToSingleResult("DisableAutoRebootOnCrash");
	}
	public static Result EnableAutoRebootOnCrash()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\CrashControl","AutoReboot",1),
		};
		return list.ToSingleResult("EnableAutoRebootOnCrash");
	}
	public static Result DisableActionCenter()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Policies\Microsoft\Windows\Explorer","DisableNotificationCenter",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\PushNotifications","ToastEnabled",0),
		};
		return list.ToSingleResult("DisableActionCenter");
	}
	public static Result EnableActionCenter()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Policies\Microsoft\Windows\Explorer", "DisableNotificationCenter"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\PushNotifications", "ToastEnabled"),
		};
		return list.ToSingleResult("EnableActionCenter");
	}
	public static Result DisableLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Personalization","NoLockScreen",1),
		};
		return list.ToSingleResult("DisableLockScreen");
	}
	public static Result EnableLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen"),
		};
		return list.ToSingleResult("EnableLockScreen");
	}
	public static Result HideNetworkFromLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\System","DontDisplayNetworkSelectionUI",1),
		};
		return list.ToSingleResult("HideNetworkFromLockScreen");
	}
	public static Result ShowNetworkOnLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\System", "DontDisplayNetworkSelectionUI"),
		};
		return list.ToSingleResult("ShowNetworkOnLockScreen");
	}
	public static Result HideShutdownFromLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ShutdownWithoutLogon",0),
		};
		return list.ToSingleResult("HideShutdownFromLockScreen");
	}
	public static Result ShowShutdownOnLockScreen()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ShutdownWithoutLogon",1),
		};
		return list.ToSingleResult("ShowShutdownOnLockScreen");
	}
	public static Result DisableLockScreenBlur()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\System","DisableAcrylicBackgroundOnLogon",1),
		};
		return list.ToSingleResult("DisableLockScreenBlur");
	}
	public static Result EnableLockScreenBlur()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\System", "DisableAcrylicBackgroundOnLogon"),
		};
		return list.ToSingleResult("EnableLockScreenBlur");
	}
	public static Result DisableAeroShake()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisallowShaking",1),
		};
		return list.ToSingleResult("DisableAeroShake");
	}
	public static Result EnableAeroShake()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking"),
		};
		return list.ToSingleResult("EnableAeroShake");
	}
	public static Result DisableAccessibilityKeys()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\StickyKeys","Flags",@"506"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\ToggleKeys","Flags",@"58"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\Keyboard Response","Flags",@"122"),
		};
		return list.ToSingleResult("DisableAccessibilityKeys");
	}
	public static Result EnableAccessibilityKeys()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\StickyKeys","Flags",@"510"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\ToggleKeys","Flags",@"62"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\Keyboard Response","Flags",@"126"),
		};
		return list.ToSingleResult("EnableAccessibilityKeys");
	}
	public static Result HideTaskManagerDetails()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("HideTaskManagerDetails");
	}
	public static Result ShowFileOperationsDetails()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager","EnthusiastMode",1),
		};
		return list.ToSingleResult("ShowFileOperationsDetails");
	}
	public static Result HideFileOperationsDetails()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager", "EnthusiastMode"),
		};
		return list.ToSingleResult("HideFileOperationsDetails");
	}
	public static Result EnableFileDeleteConfirm()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer","ConfirmFileDelete",1),
		};
		return list.ToSingleResult("EnableFileDeleteConfirm");
	}
	public static Result DisableFileDeleteConfirm()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "ConfirmFileDelete"),
		};
		return list.ToSingleResult("DisableFileDeleteConfirm");
	}
	public static Result HideTaskbarSearch()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",0),
		};
		return list.ToSingleResult("HideTaskbarSearch");
	}
	public static Result ShowTaskbarSearchIcon()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",1),
		};
		return list.ToSingleResult("ShowTaskbarSearchIcon");
	}
	public static Result ShowTaskbarSearchBox()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Search","SearchboxTaskbarMode",2),
		};
		return list.ToSingleResult("ShowTaskbarSearchBox");
	}
	public static Result HideTaskView()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowTaskViewButton",0),
		};
		return list.ToSingleResult("HideTaskView");
	}
	public static Result ShowTaskView()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton"),
		};
		return list.ToSingleResult("ShowTaskView");
	}
	public static Result ShowSmallTaskbarIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarSmallIcons",1),
		};
		return list.ToSingleResult("ShowSmallTaskbarIcons");
	}
	public static Result ShowLargeTaskbarIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSmallIcons"),
		};
		return list.ToSingleResult("ShowLargeTaskbarIcons");
	}
	public static Result SetTaskbarCombineWhenFull()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarGlomLevel",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","MMTaskbarGlomLevel",1),
		};
		return list.ToSingleResult("SetTaskbarCombineWhenFull");
	}
	public static Result SetTaskbarCombineNever()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarGlomLevel",2),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","MMTaskbarGlomLevel",2),
		};
		return list.ToSingleResult("SetTaskbarCombineNever");
	}
	public static Result SetTaskbarCombineAlways()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarGlomLevel"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "MMTaskbarGlomLevel"),
		};
		return list.ToSingleResult("SetTaskbarCombineAlways");
	}
	public static Result HideTaskbarPeopleIcon()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People","PeopleBand",0),
		};
		return list.ToSingleResult("HideTaskbarPeopleIcon");
	}
	public static Result ShowTaskbarPeopleIcon()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People", "PeopleBand"),
		};
		return list.ToSingleResult("ShowTaskbarPeopleIcon");
	}
	public static Result ShowTrayIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoAutoTrayNotify",1),
		};
		return list.ToSingleResult("ShowTrayIcons");
	}
	public static Result HideTrayIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoAutoTrayNotify"),
		};
		return list.ToSingleResult("HideTrayIcons");
	}
	public static Result ShowSecondsInTaskbar()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSecondsInSystemClock",1),
		};
		return list.ToSingleResult("ShowSecondsInTaskbar");
	}
	public static Result HideSecondsFromTaskbar()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock"),
		};
		return list.ToSingleResult("HideSecondsFromTaskbar");
	}
	public static Result DisableSearchAppInStore()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","NoUseStoreOpenWith",1),
		};
		return list.ToSingleResult("DisableSearchAppInStore");
	}
	public static Result EnableSearchAppInStore()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "NoUseStoreOpenWith"),
		};
		return list.ToSingleResult("EnableSearchAppInStore");
	}
	public static Result DisableNewAppPrompt()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","NoNewAppAlert",1),
		};
		return list.ToSingleResult("DisableNewAppPrompt");
	}
	public static Result EnableNewAppPrompt()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "NoNewAppAlert"),
		};
		return list.ToSingleResult("EnableNewAppPrompt");
	}
	public static Result HideRecentlyAddedApps()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","HideRecentlyAddedApps",1),
		};
		return list.ToSingleResult("HideRecentlyAddedApps");
	}
	public static Result ShowRecentlyAddedApps()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "HideRecentlyAddedApps"),
		};
		return list.ToSingleResult("ShowRecentlyAddedApps");
	}
	public static Result HideMostUsedApps()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoStartMenuMFUprogramsList",1),
		};
		return list.ToSingleResult("HideMostUsedApps");
	}
	public static Result ShowMostUsedApps()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoStartMenuMFUprogramsList"),
		};
		return list.ToSingleResult("ShowMostUsedApps");
	}
	public static Result SetWinXMenuPowerShell()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DontUsePowerShellOnWinX",0),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DontUsePowerShellOnWinX"),
		};
		return list.ToSingleResult("SetWinXMenuPowerShell");
	}
	public static Result SetWinXMenuCmd()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DontUsePowerShellOnWinX"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DontUsePowerShellOnWinX",1),
		};
		return list.ToSingleResult("SetWinXMenuCmd");
	}
	public static Result SetControlPanelSmallIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","StartupPage",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","AllItemsIconView",1),
		};
		return list.ToSingleResult("SetControlPanelSmallIcons");
	}
	public static Result SetControlPanelLargeIcons()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","StartupPage",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel","AllItemsIconView",0),
		};
		return list.ToSingleResult("SetControlPanelLargeIcons");
	}
	public static Result SetControlPanelCategories()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel", "StartupPage"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel", "AllItemsIconView"),
		};
		return list.ToSingleResult("SetControlPanelCategories");
	}
	public static Result DisableShortcutInName()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("DisableShortcutInName");
	}
	public static Result EnableShortcutInName()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "link"),
		};
		return list.ToSingleResult("EnableShortcutInName");
	}
	public static Result HideShortcutArrow()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons","29",@"%SystemRoot%\System32\imageres.dll,-1015"),
		};
		return list.ToSingleResult("HideShortcutArrow");
	}
	public static Result ShowShortcutArrow()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", "29"),
		};
		return list.ToSingleResult("ShowShortcutArrow");
	}
	public static Result SetVisualFXPerformance()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","DragFullWindows",@"0"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","MenuShowDelay",@"0"),
			
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop\WindowMetrics","MinAnimate",@"0"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Keyboard","KeyboardDelay",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewAlphaSelect",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewShadow",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarAnimations",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects","VisualFXSetting",3),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","EnableAeroPeek",0),
		};
		return list.ToSingleResult("SetVisualFXPerformance");
	}
	public static Result SetVisualFXAppearance()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","DragFullWindows",@"1"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","MenuShowDelay",@"400"),
			
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop\WindowMetrics","MinAnimate",@"1"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Keyboard","KeyboardDelay",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewAlphaSelect",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewShadow",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarAnimations",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects","VisualFXSetting",3),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","EnableAeroPeek",1),
		};
		return list.ToSingleResult("SetVisualFXAppearance");
	}
	public static Result EnableTitleBarColor()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","ColorPrevalence",1),
		};
		return list.ToSingleResult("EnableTitleBarColor");
	}
	public static Result DisableTitleBarColor()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","ColorPrevalence",0),
		};
		return list.ToSingleResult("DisableTitleBarColor");
	}
	public static Result SetAppsDarkMode()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","AppsUseLightTheme",0),
		};
		return list.ToSingleResult("SetAppsDarkMode");
	}
	public static Result SetAppsLightMode()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","AppsUseLightTheme",1),
		};
		return list.ToSingleResult("SetAppsLightMode");
	}
	public static Result SetSystemLightMode()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","SystemUsesLightTheme",1),
		};
		return list.ToSingleResult("SetSystemLightMode");
	}
	public static Result SetSystemDarkMode()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize","SystemUsesLightTheme",0),
		};
		return list.ToSingleResult("SetSystemDarkMode");
	}
	public static Result EnableNumlock()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.Users,@".DEFAULT\Control Panel\Keyboard","InitialKeyboardIndicators",2147483650),
		};
		return list.ToSingleResult("EnableNumlock");
	}
	public static Result DisableNumlock()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.Users,@".DEFAULT\Control Panel\Keyboard","InitialKeyboardIndicators",2147483648),
		};
		return list.ToSingleResult("DisableNumlock");
	}
	public static Result DisableEnhPointerPrecision()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseSpeed",@"0"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold1",@"0"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold2",@"0"),
		};
		return list.ToSingleResult("DisableEnhPointerPrecision");
	}
	public static Result EnableEnhPointerPrecision()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseSpeed",@"1"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold1",@"6"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Mouse","MouseThreshold2",@"10"),
		};
		return list.ToSingleResult("EnableEnhPointerPrecision");
	}
	public static Result DisableStartupSound()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\BootAnimation","DisableStartupSound",1),
		};
		return list.ToSingleResult("DisableStartupSound");
	}
	public static Result EnableStartupSound()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\BootAnimation","DisableStartupSound",0),
		};
		return list.ToSingleResult("EnableStartupSound");
	}
	public static Result DisableChangingSoundScheme()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Personalization","NoChangingSoundScheme",1),
		};
		return list.ToSingleResult("DisableChangingSoundScheme");
	}
	public static Result EnableChangingSoundScheme()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoChangingSoundScheme"),
		};
		return list.ToSingleResult("EnableChangingSoundScheme");
	}
	public static Result EnableVerboseStatus()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"Software\Microsoft\Windows\CurrentVersion\Policies\System","VerboseStatus",1),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", "VerboseStatus"),
		};
		return list.ToSingleResult("EnableVerboseStatus");
	}
	public static Result DisableVerboseStatus()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", "VerboseStatus"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"Software\Microsoft\Windows\CurrentVersion\Policies\System","VerboseStatus",0),
		};
		return list.ToSingleResult("DisableVerboseStatus");
	}
	public static Result DisableF1HelpKey()
	{
		var list = new List<Result>()
		{
			
			
		};
		return list.ToSingleResult("DisableF1HelpKey");
	}
	public static Result ShowExplorerTitleFullPath()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\CabinetState","FullPath",1),
		};
		return list.ToSingleResult("ShowExplorerTitleFullPath");
	}
	public static Result HideExplorerTitleFullPath()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\CabinetState", "FullPath"),
		};
		return list.ToSingleResult("HideExplorerTitleFullPath");
	}
	public static Result ShowKnownExtensions()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideFileExt",0),
		};
		return list.ToSingleResult("ShowKnownExtensions");
	}
	public static Result HideKnownExtensions()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideFileExt",1),
		};
		return list.ToSingleResult("HideKnownExtensions");
	}
	public static Result ShowHiddenFiles()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","Hidden",1),
		};
		return list.ToSingleResult("ShowHiddenFiles");
	}
	public static Result HideHiddenFiles()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","Hidden",2),
		};
		return list.ToSingleResult("HideHiddenFiles");
	}
	public static Result ShowSuperHiddenFiles()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSuperHidden",1),
		};
		return list.ToSingleResult("ShowSuperHiddenFiles");
	}
	public static Result HideSuperHiddenFiles()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSuperHidden",0),
		};
		return list.ToSingleResult("HideSuperHiddenFiles");
	}
	public static Result ShowEmptyDrives()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideDrivesWithNoMedia",0),
		};
		return list.ToSingleResult("ShowEmptyDrives");
	}
	public static Result HideEmptyDrives()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideDrivesWithNoMedia"),
		};
		return list.ToSingleResult("HideEmptyDrives");
	}
	public static Result ShowFolderMergeConflicts()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideMergeConflicts",0),
		};
		return list.ToSingleResult("ShowFolderMergeConflicts");
	}
	public static Result HideFolderMergeConflicts()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideMergeConflicts"),
		};
		return list.ToSingleResult("HideFolderMergeConflicts");
	}
	public static Result EnableNavPaneExpand()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","NavPaneExpandToCurrentFolder",1),
		};
		return list.ToSingleResult("EnableNavPaneExpand");
	}
	public static Result DisableNavPaneExpand()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "NavPaneExpandToCurrentFolder"),
		};
		return list.ToSingleResult("DisableNavPaneExpand");
	}
	public static Result ShowNavPaneAllFolders()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","NavPaneShowAllFolders",1),
		};
		return list.ToSingleResult("ShowNavPaneAllFolders");
	}
	public static Result HideNavPaneAllFolders()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "NavPaneShowAllFolders"),
		};
		return list.ToSingleResult("HideNavPaneAllFolders");
	}
	public static Result ShowNavPaneLibraries()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Classes\CLSID\{031E4825-7B94-4dc3-B131-E946B44C8DD5}","System.IsPinnedToNameSpaceTree",1),
		};
		return list.ToSingleResult("ShowNavPaneLibraries");
	}
	public static Result HideNavPaneLibraries()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Classes\CLSID\{031E4825-7B94-4dc3-B131-E946B44C8DD5}", "System.IsPinnedToNameSpaceTree"),
		};
		return list.ToSingleResult("HideNavPaneLibraries");
	}
	public static Result EnableFldrSeparateProcess()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SeparateProcess",1),
		};
		return list.ToSingleResult("EnableFldrSeparateProcess");
	}
	public static Result DisableFldrSeparateProcess()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SeparateProcess",0),
		};
		return list.ToSingleResult("DisableFldrSeparateProcess");
	}
	public static Result EnableRestoreFldrWindows()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","PersistBrowsers",1),
		};
		return list.ToSingleResult("EnableRestoreFldrWindows");
	}
	public static Result DisableRestoreFldrWindows()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "PersistBrowsers"),
		};
		return list.ToSingleResult("DisableRestoreFldrWindows");
	}
	public static Result ShowEncCompFilesColor()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowEncryptCompressedColor",1),
		};
		return list.ToSingleResult("ShowEncCompFilesColor");
	}
	public static Result HideEncCompFilesColor()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowEncryptCompressedColor"),
		};
		return list.ToSingleResult("HideEncCompFilesColor");
	}
	public static Result DisableSharingWizard()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SharingWizardOn",0),
		};
		return list.ToSingleResult("DisableSharingWizard");
	}
	public static Result EnableSharingWizard()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "SharingWizardOn"),
		};
		return list.ToSingleResult("EnableSharingWizard");
	}
	public static Result HideSelectCheckboxes()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","AutoCheckSelect",0),
		};
		return list.ToSingleResult("HideSelectCheckboxes");
	}
	public static Result ShowSelectCheckboxes()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","AutoCheckSelect",1),
		};
		return list.ToSingleResult("ShowSelectCheckboxes");
	}
	public static Result HideSyncNotifications()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSyncProviderNotifications",0),
		};
		return list.ToSingleResult("HideSyncNotifications");
	}
	public static Result ShowSyncNotifications()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSyncProviderNotifications",1),
		};
		return list.ToSingleResult("ShowSyncNotifications");
	}
	public static Result HideRecentShortcuts()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer","ShowRecent",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer","ShowFrequent",0),
		};
		return list.ToSingleResult("HideRecentShortcuts");
	}
	public static Result ShowRecentShortcuts()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "ShowRecent"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer", "ShowFrequent"),
		};
		return list.ToSingleResult("ShowRecentShortcuts");
	}
	public static Result SetExplorerThisPC()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","LaunchTo",1),
		};
		return list.ToSingleResult("SetExplorerThisPC");
	}
	public static Result SetExplorerQuickAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "LaunchTo"),
		};
		return list.ToSingleResult("SetExplorerQuickAccess");
	}
	public static Result HideQuickAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer","HubMode",1),
		};
		return list.ToSingleResult("HideQuickAccess");
	}
	public static Result ShowQuickAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "HubMode"),
		};
		return list.ToSingleResult("ShowQuickAccess");
	}
	public static Result HideRecycleBinFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{645FF040-5081-101B-9F08-00AA002F954E}",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{645FF040-5081-101B-9F08-00AA002F954E}",1),
		};
		return list.ToSingleResult("HideRecycleBinFromDesktop");
	}
	public static Result ShowRecycleBinOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{645FF040-5081-101B-9F08-00AA002F954E}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{645FF040-5081-101B-9F08-00AA002F954E}"),
		};
		return list.ToSingleResult("ShowRecycleBinOnDesktop");
	}
	public static Result ShowThisPCOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{20D04FE0-3AEA-1069-A2D8-08002B30309D}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{20D04FE0-3AEA-1069-A2D8-08002B30309D}",0),
		};
		return list.ToSingleResult("ShowThisPCOnDesktop");
	}
	public static Result HideThisPCFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{20D04FE0-3AEA-1069-A2D8-08002B30309D}"),
		};
		return list.ToSingleResult("HideThisPCFromDesktop");
	}
	public static Result ShowUserFolderOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{59031a47-3f72-44a7-89c5-5595fe6b30ee}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{59031a47-3f72-44a7-89c5-5595fe6b30ee}",0),
		};
		return list.ToSingleResult("ShowUserFolderOnDesktop");
	}
	public static Result HideUserFolderFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{59031a47-3f72-44a7-89c5-5595fe6b30ee}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{59031a47-3f72-44a7-89c5-5595fe6b30ee}"),
		};
		return list.ToSingleResult("HideUserFolderFromDesktop");
	}
	public static Result ShowControlPanelOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}",0),
		};
		return list.ToSingleResult("ShowControlPanelOnDesktop");
	}
	public static Result HideControlPanelFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{5399E694-6CE5-4D6C-8FCE-1D8870FDCBA0}"),
		};
		return list.ToSingleResult("HideControlPanelFromDesktop");
	}
	public static Result ShowNetworkOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",0),
		};
		return list.ToSingleResult("ShowNetworkOnDesktop");
	}
	public static Result HideNetworkFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\ClassicStartMenu", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
		};
		return list.ToSingleResult("HideNetworkFromDesktop");
	}
	public static Result HideDesktopIcons()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("HideDesktopIcons");
	}
	public static Result ShowDesktopIcons()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("ShowDesktopIcons");
	}
	public static Result ShowBuildNumberOnDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Desktop","PaintDesktopVersion",1),
		};
		return list.ToSingleResult("ShowBuildNumberOnDesktop");
	}
	public static Result HideBuildNumberFromDesktop()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Desktop","PaintDesktopVersion",0),
		};
		return list.ToSingleResult("HideBuildNumberFromDesktop");
	}
	public static Result HideDesktopFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HideDesktopFromExplorer");
	}
	public static Result ShowDesktopInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowDesktopInExplorer");
	}
	public static Result HideDocumentsFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HideDocumentsFromExplorer");
	}
	public static Result ShowDocumentsInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowDocumentsInExplorer");
	}
	public static Result HideDownloadsFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HideDownloadsFromExplorer");
	}
	public static Result ShowDownloadsInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowDownloadsInExplorer");
	}
	public static Result HideMusicFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HideMusicFromExplorer");
	}
	public static Result ShowMusicInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowMusicInExplorer");
	}
	public static Result HidePicturesFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HidePicturesFromExplorer");
	}
	public static Result ShowPicturesInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowPicturesInExplorer");
	}
	public static Result HideVideosFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{35286a68-3c57-41a1-bbb1-0eae73d76c95}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{35286a68-3c57-41a1-bbb1-0eae73d76c95}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("HideVideosFromExplorer");
	}
	public static Result ShowVideosInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{35286a68-3c57-41a1-bbb1-0eae73d76c95}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{35286a68-3c57-41a1-bbb1-0eae73d76c95}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowVideosInExplorer");
	}
	public static Result Hide3DObjectsFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.ToSingleResult("Hide3DObjectsFromExplorer");
	}
	public static Result Show3DObjectsInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag", "ThisPCPolicy"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag", "ThisPCPolicy"),
		};
		return list.ToSingleResult("Show3DObjectsInExplorer");
	}
	public static Result HideNetworkFromExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",1),
		};
		return list.ToSingleResult("HideNetworkFromExplorer");
	}
	public static Result ShowNetworkInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
		};
		return list.ToSingleResult("ShowNetworkInExplorer");
	}
	public static Result ShowIncludeInLibraryMenu()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Folder\ShellEx\ContextMenuHandlers\Library Location","(Default)",@"{3dad6c5d-2167-4cae-9914-f99e41c12cfa}"),
		};
		return list.ToSingleResult("ShowIncludeInLibraryMenu");
	}
	public static Result ShowGiveAccessToMenu()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.ClassesRoot,@"*\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Directory\Background\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Directory\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Drive\shellex\ContextMenuHandlers\Sharing","(Default)",@"{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}"),
		};
		return list.ToSingleResult("ShowGiveAccessToMenu");
	}
	public static Result ShowShareMenu()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.ClassesRoot,@"*\shellex\ContextMenuHandlers\ModernSharing","(Default)",@"{e2bf9676-5f8f-435c-97eb-11607a5bedf7}"),
		};
		return list.ToSingleResult("ShowShareMenu");
	}
	public static Result DisableThumbnails()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","IconsOnly",1),
		};
		return list.ToSingleResult("DisableThumbnails");
	}
	public static Result EnableThumbnails()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","IconsOnly",0),
		};
		return list.ToSingleResult("EnableThumbnails");
	}
	public static Result DisableThumbnailCache()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisableThumbnailCache",1),
		};
		return list.ToSingleResult("DisableThumbnailCache");
	}
	public static Result EnableThumbnailCache()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbnailCache"),
		};
		return list.ToSingleResult("EnableThumbnailCache");
	}
	public static Result DisableThumbsDBOnNetwork()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisableThumbsDBOnNetworkFolders",1),
		};
		return list.ToSingleResult("DisableThumbsDBOnNetwork");
	}
	public static Result EnableThumbsDBOnNetwork()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisableThumbsDBOnNetworkFolders"),
		};
		return list.ToSingleResult("EnableThumbsDBOnNetwork");
	}
	public static Result DisableOneDrive()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\OneDrive","DisableFileSyncNGSC",1),
		};
		return list.ToSingleResult("DisableOneDrive");
	}
	public static Result EnableOneDrive()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC"),
		};
		return list.ToSingleResult("EnableOneDrive");
	}
	public static Result DisableXboxFeatures()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\GameBar","AutoGameModeEnabled",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_Enabled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\GameDVR","AllowGameDVR",0),
		};
		return list.ToSingleResult("DisableXboxFeatures");
	}
	public static Result EnableXboxFeatures()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\GameBar", "AutoGameModeEnabled"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_Enabled",1),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\GameDVR", "AllowGameDVR"),
		};
		return list.ToSingleResult("EnableXboxFeatures");
	}
	public static Result DisableFullscreenOptims()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_DXGIHonorFSEWindowsCompatible",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehavior",2),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehaviorMode",2),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_HonorUserFSEBehaviorMode",1),
		};
		return list.ToSingleResult("DisableFullscreenOptims");
	}
	public static Result EnableFullscreenOptims()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_DXGIHonorFSEWindowsCompatible",0),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"System\GameConfigStore", "GameDVR_FSEBehavior"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehaviorMode",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_HonorUserFSEBehaviorMode",0),
		};
		return list.ToSingleResult("EnableFullscreenOptims");
	}
	public static Result DisableAdobeFlash()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Internet Explorer","DisableFlashInIE",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Addons","FlashPlayerEnabled",0),
		};
		return list.ToSingleResult("DisableAdobeFlash");
	}
	public static Result EnableAdobeFlash()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Internet Explorer", "DisableFlashInIE"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Addons", "FlashPlayerEnabled"),
		};
		return list.ToSingleResult("EnableAdobeFlash");
	}
	public static Result DisableEdgePreload()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main","AllowPrelaunch",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\MicrosoftEdge\TabPreloader","AllowTabPreloading",0),
		};
		return list.ToSingleResult("DisableEdgePreload");
	}
	public static Result EnableEdgePreload()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\Main", "AllowPrelaunch"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\MicrosoftEdge\TabPreloader", "AllowTabPreloading"),
		};
		return list.ToSingleResult("EnableEdgePreload");
	}
	public static Result DisableEdgeShortcutCreation()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer","DisableEdgeDesktopShortcutCreation",1),
		};
		return list.ToSingleResult("DisableEdgeShortcutCreation");
	}
	public static Result EnableEdgeShortcutCreation()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "DisableEdgeDesktopShortcutCreation"),
		};
		return list.ToSingleResult("EnableEdgeShortcutCreation");
	}
	public static Result DisableIEFirstRun()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Internet Explorer\Main","DisableFirstRunCustomize",1),
		};
		return list.ToSingleResult("DisableIEFirstRun");
	}
	public static Result EnableIEFirstRun()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Internet Explorer\Main", "DisableFirstRunCustomize"),
		};
		return list.ToSingleResult("EnableIEFirstRun");
	}
	public static Result DisableFirstLogonAnimation()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","EnableFirstLogonAnimation",0),
		};
		return list.ToSingleResult("DisableFirstLogonAnimation");
	}
	public static Result EnableFirstLogonAnimation()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableFirstLogonAnimation"),
		};
		return list.ToSingleResult("EnableFirstLogonAnimation");
	}
	public static Result DisableMediaSharing()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventLibrarySharing",1),
		};
		return list.ToSingleResult("DisableMediaSharing");
	}
	public static Result EnableMediaSharing()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventLibrarySharing"),
		};
		return list.ToSingleResult("EnableMediaSharing");
	}
	public static Result DisableMediaOnlineAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventCDDVDMetadataRetrieval",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventMusicFileMetadataRetrieval",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventRadioPresetsRetrieval",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WMDRM","DisableOnline",1),
		};
		return list.ToSingleResult("DisableMediaOnlineAccess");
	}
	public static Result EnableMediaOnlineAccess()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventCDDVDMetadataRetrieval"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventMusicFileMetadataRetrieval"),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventRadioPresetsRetrieval"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WMDRM", "DisableOnline"),
		};
		return list.ToSingleResult("EnableMediaOnlineAccess");
	}
	public static Result EnableDeveloperMode()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock","AllowDevelopmentWithoutDevLicense",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock","AllowAllTrustedApps",1),
		};
		return list.ToSingleResult("EnableDeveloperMode");
	}
	public static Result DisableDeveloperMode()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock", "AllowDevelopmentWithoutDevLicense"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock", "AllowAllTrustedApps"),
		};
		return list.ToSingleResult("DisableDeveloperMode");
	}
	public static Result SetPhotoViewerAssociation()
	{
		var list = new List<Result>()
		{
			
			
		};
		return list.ToSingleResult("SetPhotoViewerAssociation");
	}
	public static Result UnsetPhotoViewerAssociation()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.ClassesRoot, @"giffile\shell\open", "MuiVerb"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open","CommandId",@"IE.File"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open\command","(Default)",@"`$env:SystemDrive\Program Files\Internet Explorer\iexplore.exe` %1"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open\command","DelegateExecute",@"{17FE9752-0B5A-4665-84CD-569794602F5C}"),
		};
		return list.ToSingleResult("UnsetPhotoViewerAssociation");
	}
	public static Result AddPhotoViewerOpenWith()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Applications\photoviewer.dll\shell\open","MuiVerb",@"@photoviewer.dll,-3043"),
			
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Applications\photoviewer.dll\shell\open\DropTarget","Clsid",@"{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}"),
		};
		return list.ToSingleResult("AddPhotoViewerOpenWith");
	}
	public static Result HideServerManagerOnLogin()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Server\ServerManager","DoNotOpenAtLogon",1),
		};
		return list.ToSingleResult("HideServerManagerOnLogin");
	}
	public static Result ShowServerManagerOnLogin()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Server\ServerManager", "DoNotOpenAtLogon"),
		};
		return list.ToSingleResult("ShowServerManagerOnLogin");
	}
	public static Result DisableShutdownTracker()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\Reliability","ShutdownReasonOn",0),
		};
		return list.ToSingleResult("DisableShutdownTracker");
	}
	public static Result EnableShutdownTracker()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\Reliability", "ShutdownReasonOn"),
		};
		return list.ToSingleResult("EnableShutdownTracker");
	}
	public static Result DisableCtrlAltDelLogin()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableCAD",1),
		};
		return list.ToSingleResult("DisableCtrlAltDelLogin");
	}
	public static Result EnableCtrlAltDelLogin()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","DisableCAD",0),
		};
		return list.ToSingleResult("EnableCtrlAltDelLogin");
	}
	public static Result DisableIEEnhancedSecurity()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Active Setup\Installed Components\{A509B1A7-37EF-4b3f-8CFC-4F3A74704073}","IsInstalled",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Active Setup\Installed Components\{A509B1A8-37EF-4b3f-8CFC-4F3A74704073}","IsInstalled",0),
		};
		return list.ToSingleResult("DisableIEEnhancedSecurity");
	}
	public static Result EnableIEEnhancedSecurity()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Active Setup\Installed Components\{A509B1A7-37EF-4b3f-8CFC-4F3A74704073}","IsInstalled",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Active Setup\Installed Components\{A509B1A8-37EF-4b3f-8CFC-4F3A74704073}","IsInstalled",1),
		};
		return list.ToSingleResult("EnableIEEnhancedSecurity");
	}
	public static Result EnableAudio()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("Audiosrv","Automatic"),
			ServiceHelper.StartService("Audiosrv"),
		};
		return list.ToSingleResult("EnableAudio");
	}
	public static Result DisableAudio()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("Audiosrv"),
			ServiceHelper.SetService("Audiosrv","Manual"),
		};
		return list.ToSingleResult("DisableAudio");
	}
	public static Result UnpinTaskbarIcons()
	{
		var list = new List<Result>()
		{
			
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Taskband", "FavoritesResolve"),
		};
		return list.ToSingleResult("UnpinTaskbarIcons");
	}
}
