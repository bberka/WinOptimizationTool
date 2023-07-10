namespace WinOptimizationTool.Functions.Registry.Service;

public class SharedExperiences : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\CDP","RomeSdkChannelUserAuthzPolicy",0),
		};
		return list.CombineAll("DisableSharedExperiences");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\CDP","RomeSdkChannelUserAuthzPolicy",1),
		};
		return list.CombineAll("EnableSharedExperiences");
	}
}
