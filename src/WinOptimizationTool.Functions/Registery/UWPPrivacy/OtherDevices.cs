﻿namespace WinOptimizationTool.Functions.Registery.UWPPrivacy;

public class OtherDevices : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy","LetAppsSyncWithDevices",2),
		};
		return list.ToSingleResult("DisableUWPOtherDevices");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsSyncWithDevices"),
		};
		return list.ToSingleResult("EnableUWPOtherDevices");
	}
}