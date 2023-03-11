namespace WinOptimizationTool.Functions.Registry.Security;

public class UAC : BaseFunction
{
	public static Result SetLow()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ConsentPromptBehaviorAdmin",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","PromptOnSecureDesktop",0),
		};
		return list.ToSingleResult("SetUACLow");
	}
	public static Result SetHigh()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","ConsentPromptBehaviorAdmin",5),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","PromptOnSecureDesktop",1),
		};
		return list.ToSingleResult("SetUACHigh");
	}
}
