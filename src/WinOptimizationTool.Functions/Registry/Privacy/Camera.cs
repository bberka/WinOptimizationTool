namespace WinOptimizationTool.Functions.Registry.Privacy;

public class Camera : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessCamera",2),
		};
		return list.ToSingleResult("DisableCamera");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessCamera"),
		};
		return list.ToSingleResult("EnableCamera");
	}
}
