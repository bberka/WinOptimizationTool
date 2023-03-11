namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DownloadsExplorer : BaseFunction
{
	public static Result ShowDownloadsInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{7d83ee9b-2244-4e70-b1f5-5393042af1e4}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowDownloadsInExplorer");
	}
}
