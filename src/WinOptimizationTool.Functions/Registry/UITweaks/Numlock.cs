namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class Numlock : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKU\" -PSProvider \"Registry\" -Root \"HKEY_USERS\" | Out-Null"),
			RegHelper.SetDword(RegistryHive.Users,@".DEFAULT\Control Panel\Keyboard","InitialKeyboardIndicators",2147483650),
			Result.Error("Not Implemented","Add-Type -AssemblyName System.Windows.Forms"),
			Result.Error("Not Implemented","$wsh = New-Object -ComObject WScript.Shell"),
			Result.Error("Not Implemented","$wsh.SendKeys('{NUMLOCK}')"),
		};
		return list.CombineAll("EnableNumlock");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKU\" -PSProvider \"Registry\" -Root \"HKEY_USERS\" | Out-Null"),
			RegHelper.SetDword(RegistryHive.Users,@".DEFAULT\Control Panel\Keyboard","InitialKeyboardIndicators",2147483648),
			Result.Error("Not Implemented","Add-Type -AssemblyName System.Windows.Forms"),
			Result.Error("Not Implemented","$wsh = New-Object -ComObject WScript.Shell"),
			Result.Error("Not Implemented","$wsh.SendKeys('{NUMLOCK}')"),
		};
		return list.CombineAll("DisableNumlock");
	}
}
