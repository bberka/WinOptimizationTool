﻿namespace WinOptimizationTool.Functions.Registery.Service;

public class RecycleBin : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoRecycleFiles",1),
		};
		return list.ToSingleResult("DisableRecycleBin");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecycleFiles"),
		};
		return list.ToSingleResult("EnableRecycleBin");
	}

}