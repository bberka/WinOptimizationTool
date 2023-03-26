namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DesktopOnExplorer : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.Combine(true,"HideDesktopFromExplorer");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.Combine(true,"ShowDesktopInExplorer");
	}
}
