namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class AeroShake : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","DisallowShaking",1),
		};
		return list.Combine(true,"DisableAeroShake");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking"),
		};
		return list.Combine(true,"EnableAeroShake");
	}
}
