namespace WinOptimizationTool.Functions.Registry.Security;

public class AccountProtectionWarn : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows Security Health\State","AccountProtection_MicrosoftAccount_Disconnected",1),
		};
		return list.ToSingleResult("HideAccountProtectionWarn");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows Security Health\State", "AccountProtection_MicrosoftAccount_Disconnected"),
		};
		return list.ToSingleResult("ShowAccountProtectionWarn");
	}
}
