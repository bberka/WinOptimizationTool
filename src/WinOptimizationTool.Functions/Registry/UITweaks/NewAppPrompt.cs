namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class NewAppPrompt : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\Explorer","NoNewAppAlert",1),
		};
		return list.ToSingleResult("DisableNewAppPrompt");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\Explorer", "NoNewAppAlert"),
		};
		return list.ToSingleResult("EnableNewAppPrompt");
	}
}
