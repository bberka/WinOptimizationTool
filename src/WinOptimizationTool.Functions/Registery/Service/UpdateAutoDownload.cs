﻿namespace WinOptimizationTool.Functions.Registery.Service;

public class UpdateAutoDownload : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU","AUOptions",2),
		};
		return list.ToSingleResult("DisableUpdateAutoDownload");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions"),
		};
		return list.ToSingleResult("EnableUpdateAutoDownload");
	}
}