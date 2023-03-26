namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DocumentsOnExplorer : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.Combine(true,"HideDocumentsFromExplorer");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.Combine(true,"ShowDocumentsInExplorer");
	}
}
