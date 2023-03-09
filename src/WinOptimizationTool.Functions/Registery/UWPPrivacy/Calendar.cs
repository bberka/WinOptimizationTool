namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class Calendar : BaseFunction
{

	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessCalendar",2),
		};
		return list.ToSingleResult("DisableUWPCalendar");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessCalendar"),
		};
		return list.ToSingleResult("EnableUWPCalendar");
	}
}