﻿namespace WinOptimizationTool.Functions.Registery.Service;

public class UpdateMSProducts : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","(New-Object -ComObject Microsoft.Update.ServiceManager).AddService2(\"7971f918-a847-4430-9279-4a52d1efe18d\", 7, \"\") | Out-Null"),
		};
		return list.ToSingleResult("EnableUpdateMSProducts");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","(New-Object -ComObject Microsoft.Update.ServiceManager).RemoveService(\"7971f918-a847-4430-9279-4a52d1efe18d\") | Out-Null"),
		};
		return list.ToSingleResult("DisableUpdateMSProducts");
	}
}