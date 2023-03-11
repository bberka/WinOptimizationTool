namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DesktopFromThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}"),
		};
		return list.ToSingleResult("HideDesktopFromThisPC");
	}
}
