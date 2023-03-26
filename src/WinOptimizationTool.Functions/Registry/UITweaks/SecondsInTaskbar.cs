namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class SecondsInTaskbar : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowSecondsInSystemClock",1),
		};
		return list.Combine(true,"ShowSecondsInTaskbar");
	}
    public static Result Hide()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSecondsInSystemClock"),
        };
        return list.Combine(true,"HideSecondsFromTaskbar");
    }
}
