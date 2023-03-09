namespace WinOptimizationTool.Functions.Registery.Privacy;

public class Microphone : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessMicrophone",2),
		};
		return list.ToSingleResult("DisableMicrophone");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessMicrophone"),
		};
		return list.ToSingleResult("EnableMicrophone");
	}
}