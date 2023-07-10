namespace WinOptimizationTool.Functions.Registry.Application;

public class EdgeShortcutCreation : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer","DisableEdgeDesktopShortcutCreation",1),
		};
		return list.CombineAll("DisableEdgeShortcutCreation");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "DisableEdgeDesktopShortcutCreation"),
		};
		return list.CombineAll("EnableEdgeShortcutCreation");
	}
}
