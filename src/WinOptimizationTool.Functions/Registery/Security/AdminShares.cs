﻿namespace WinOptimizationTool.Functions.Registery.Security;

public class AdminShares : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters","AutoShareServer",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters","AutoShareWks",0),
		};
		return list.ToSingleResult("DisableAdminShares");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "AutoShareServer"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters", "AutoShareWks"),
		};
		return list.ToSingleResult("EnableAdminShares");
	}
}