namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class MostUsedApps : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoStartMenuMFUprogramsList",1),
		};
		return list.CombineAll("HideMostUsedApps");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoStartMenuMFUprogramsList"),
		};
		return list.CombineAll("ShowMostUsedApps");
	}
}
