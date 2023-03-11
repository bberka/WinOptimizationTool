namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DocumentsExplorer : BaseFunction
{
	public static Result ShowDocumentsInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{f42ee2d3-909f-4907-8871-4c22fc0bf756}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowDocumentsInExplorer");
	}
}
