﻿namespace WinOptimizationTool.Functions.Registery.Service;

public class FastStartup : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",0),
		};
		return list.ToSingleResult("DisableFastStartup");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Session Manager\Power","HiberbootEnabled",1),
		};
		return list.ToSingleResult("EnableFastStartup");
	}
}