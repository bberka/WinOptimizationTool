namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPBackgroundApps : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsRunInBackground",2),
		};
		return list.CombineAll("DisableUWPBackgroundApps");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsRunInBackground"),
			Result.Error("Not Implemented","Get-ChildItem -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\" | ForEach-Object {"),
		};
		return list.CombineAll("EnableUWPBackgroundApps");
	}
}
