namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class PicturesOnExplorer : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
		};
		return list.Combine(true,"HidePicturesFromExplorer");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
			RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
		};
		return list.Combine(true,"ShowPicturesInExplorer");
	}
}
