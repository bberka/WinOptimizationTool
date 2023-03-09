﻿namespace WinOptimizationTool.Functions.Registery.Network;

public class IPv4
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip\""),
		};
		return list.ToSingleResult("DisableIPv4");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_tcpip\""),
		};
		return list.ToSingleResult("EnableIPv4");
	}
}