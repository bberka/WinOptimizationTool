namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class TaskManagerDetails : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$taskmgr = Start-Process -WindowStyle Hidden -FilePath taskmgr.exe -PassThru"),
			Result.Error("Not Implemented","$timeout = 30000"),
			Result.Error("Not Implemented","$sleep = 100"),
			Result.Error("Not Implemented","Do {"),
			Result.Error("Not Implemented","Start-Sleep -Milliseconds $sleep"),
			Result.Error("Not Implemented","$timeout -= $sleep"),
			Result.Error("Not Implemented","$preferences = Get-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\TaskManager\" -Name \"Preferences\" -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("ShowTaskManagerDetails");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$preferences = Get-ItemProperty -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\TaskManager\" -Name \"Preferences\" -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","$preferences.Preferences[28] = 1"),
			
		};
		return list.CombineAll("HideTaskManagerDetails");
	}
}
