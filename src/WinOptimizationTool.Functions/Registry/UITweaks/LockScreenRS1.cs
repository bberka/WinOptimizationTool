namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class LockScreenRS1 : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$service = New-Object -com Schedule.Service"),
			Result.Error("Not Implemented","$service.Connect()"),
			Result.Error("Not Implemented","$task = $service.NewTask(0)"),
			Result.Error("Not Implemented","$task.Settings.DisallowStartIfOnBatteries = $false"),
			Result.Error("Not Implemented","$trigger = $task.Triggers.Create(9)"),
			Result.Error("Not Implemented","$trigger = $task.Triggers.Create(11)"),
			Result.Error("Not Implemented","$trigger.StateChange = 8"),
			Result.Error("Not Implemented","$action = $task.Actions.Create(0)"),
			Result.Error("Not Implemented","$action.Path = \"reg.exe\""),
			Result.Error("Not Implemented","$action.Arguments = \"add HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\SessionData /t REG_DWORD /v AllowLockScreen /d 0 /f\""),
			Result.Error("Not Implemented","$service.GetFolder(\"\\\").RegisterTaskDefinition(\"Disable LockScreen\", $task, 6, \"NT AUTHORITY\\SYSTEM\", $null, 4) | Out-Null"),
		};
		return list.CombineAll("DisableLockScreenRS1");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Unregister-ScheduledTask -TaskName \"Disable LockScreen\" -Confirm:$false -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("EnableLockScreenRS1");
	}
}
