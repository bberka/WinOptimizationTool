﻿namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class Radios : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsAccessRadios",2),
		};
		return list.ToSingleResult("DisableUWPRadios");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsAccessRadios"),
		};
		return list.ToSingleResult("EnableUWPRadios");
	}
}