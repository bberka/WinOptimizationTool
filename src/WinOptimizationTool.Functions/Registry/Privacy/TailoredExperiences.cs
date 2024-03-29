namespace WinOptimizationTool.Functions.Registry.Privacy;

public class TailoredExperiences : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Policies\Microsoft\Windows\CloudContent","DisableTailoredExperiencesWithDiagnosticData",1),
		};
		return list.CombineAll("DisableTailoredExperiences");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Policies\Microsoft\Windows\CloudContent", "DisableTailoredExperiencesWithDiagnosticData"),
		};
		return list.CombineAll("EnableTailoredExperiences");
	}
}
