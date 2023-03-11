namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ChangingSoundScheme : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Personalization","NoChangingSoundScheme",1),
		};
		return list.ToSingleResult("DisableChangingSoundScheme");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoChangingSoundScheme"),
		};
		return list.ToSingleResult("EnableChangingSoundScheme");
	}
}
