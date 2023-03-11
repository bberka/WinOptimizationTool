namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class DocumentsOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{d3162b92-9365-467a-956b-92703aca08af}"),
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}"),
		};
		return list.ToSingleResult("HideDocumentsFromThisPC");
	}
    [NotImplemented]
    public static Result Show()
    {
        throw new NotImplementedException();
    }
}
