﻿namespace WinOptimizationTool.Functions.Registery.Privacy;

public class Biometrics : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Biometrics","Enabled",0),
		};
		return list.ToSingleResult("DisableBiometrics");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Biometrics", "Enabled"),
		};
		return list.ToSingleResult("EnableBiometrics");
	}
}