namespace WinOptimizationTool.Functions.Registry.Service;

public class ClipboardHistory : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Clipboard","EnableClipboardHistory",1),
		};
		return list.Combine(true,"EnableClipboardHistory");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Clipboard", "EnableClipboardHistory"),
		};
		return list.Combine(true,"DisableClipboardHistory");
	}
}
