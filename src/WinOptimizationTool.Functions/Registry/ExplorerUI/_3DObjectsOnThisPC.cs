namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class _3DObjectsOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}"),
		};
		return list.CombineAll("Hide3DObjectsFromThisPC");
	}
	[NotImplemented]
    public static Result Show()
    {
       throw new NotImplementedException();
    }
}
