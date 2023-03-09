﻿namespace WinOptimizationTool.Functions.Registery.Privacy;

public class DiagTrack : BaseFunction 
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.StopService("DiagTrack"),
			ServiceHelper.SetService("DiagTrack","Disabled"),
		};
		return list.ToSingleResult("DisableDiagTrack");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			ServiceHelper.SetService("DiagTrack","Automatic"),
			ServiceHelper.StartService("DiagTrack"),
		};
		return list.ToSingleResult("EnableDiagTrack");
	}
}