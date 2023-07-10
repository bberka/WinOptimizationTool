namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DownloadsOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{088e3905-0323-4b02-9826-5d99428e115f}"),
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{374DE290-123F-4565-9164-39C4925E467B}"),
		};
		return list.CombineAll("HideDownloadsFromThisPC");
	}
    [NotImplemented]
    public static Result Show()
    {
        throw new NotImplementedException();
    }
}
