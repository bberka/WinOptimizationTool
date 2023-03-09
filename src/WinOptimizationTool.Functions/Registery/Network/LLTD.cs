﻿namespace WinOptimizationTool.Functions.Registery.Network;

public class LLTD
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.MultipleErrors("Not Implemented","Disable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.ToSingleResult("DisableLLTD");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_lltdio\""),
			Result.MultipleErrors("Not Implemented","Enable-NetAdapterBinding -Name \"*\" -ComponentID \"ms_rspndr\""),
		};
		return list.ToSingleResult("EnableLLTD");
	}
}