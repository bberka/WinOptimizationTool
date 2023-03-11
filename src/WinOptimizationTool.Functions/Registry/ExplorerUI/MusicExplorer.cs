namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class MusicExplorer : BaseFunction
{
	public static Result ShowMusicInExplorer()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{a0c69a99-21c8-4671-8703-7934162fcf1d}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.ToSingleResult("ShowMusicInExplorer");
	}
}
