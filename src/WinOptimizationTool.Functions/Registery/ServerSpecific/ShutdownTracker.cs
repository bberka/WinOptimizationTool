﻿namespace WinOptimizationTool.Functions.Registery.ServerSpecific;

public class ShutdownTracker : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\Reliability","ShutdownReasonOn",0),
		};
		return list.ToSingleResult("DisableShutdownTracker");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\Reliability", "ShutdownReasonOn"),
		};
		return list.ToSingleResult("EnableShutdownTracker");
	}
}