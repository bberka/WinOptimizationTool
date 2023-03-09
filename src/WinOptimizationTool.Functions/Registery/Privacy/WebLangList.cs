namespace WinOptimizationTool.Functions.Registery.Privacy;

public class WebLangList : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\International\User Profile","HttpAcceptLanguageOptOut",1),
		};
		return list.ToSingleResult("DisableWebLangList");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Control Panel\International\User Profile", "HttpAcceptLanguageOptOut"),
		};
		return list.ToSingleResult("EnableWebLangList");
	}
}