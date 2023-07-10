namespace WinOptimizationTool.Functions.Registry.Privacy;

public class Biometrics : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Biometrics","Enabled",0),
		};
		return list.CombineAll("DisableBiometrics");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Biometrics", "Enabled"),
		};
		return list.CombineAll("EnableBiometrics");
	}
}
