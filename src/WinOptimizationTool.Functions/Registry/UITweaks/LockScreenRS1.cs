namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class LockScreenRS1 : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$service = New-Object -com Schedule.Service"),
			Result.MultipleErrors("Not Implemented","$service.Connect()"),
			Result.MultipleErrors("Not Implemented","$task = $service.NewTask(0)"),
			Result.MultipleErrors("Not Implemented","$task.Settings.DisallowStartIfOnBatteries = $false"),
			Result.MultipleErrors("Not Implemented","$trigger = $task.Triggers.Create(9)"),
			Result.MultipleErrors("Not Implemented","$trigger = $task.Triggers.Create(11)"),
			Result.MultipleErrors("Not Implemented","$trigger.StateChange = 8"),
			Result.MultipleErrors("Not Implemented","$action = $task.Actions.Create(0)"),
			Result.MultipleErrors("Not Implemented","$action.Path = \"reg.exe\""),
			Result.MultipleErrors("Not Implemented","$action.Arguments = \"add HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\SessionData /t REG_DWORD /v AllowLockScreen /d 0 /f\""),
			Result.MultipleErrors("Not Implemented","$service.GetFolder(\"\\\").RegisterTaskDefinition(\"Disable LockScreen\", $task, 6, \"NT AUTHORITY\\SYSTEM\", $null, 4) | Out-Null"),
		};
		return list.ToSingleResult("DisableLockScreenRS1");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Unregister-ScheduledTask -TaskName \"Disable LockScreen\" -Confirm:$false -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("EnableLockScreenRS1");
	}
}
