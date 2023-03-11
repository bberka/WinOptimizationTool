namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskManagerDetails : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$taskmgr = Start-Process -WindowStyle Hidden -FilePath taskmgr.exe -PassThru"),
			Result.MultipleErrors("Not Implemented","$timeout = 30000"),
			Result.MultipleErrors("Not Implemented","$sleep = 100"),
			Result.MultipleErrors("Not Implemented","Do {"),
			Result.MultipleErrors("Not Implemented","Start-Sleep -Milliseconds $sleep"),
			Result.MultipleErrors("Not Implemented","$timeout -= $sleep"),
			Result.MultipleErrors("Not Implemented","$preferences = Get-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\TaskManager\" -Name \"Preferences\" -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("ShowTaskManagerDetails");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$preferences = Get-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\TaskManager\" -Name \"Preferences\" -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","$preferences.Preferences[28] = 1"),
			
		};
		return list.ToSingleResult("HideTaskManagerDetails");
	}
}
