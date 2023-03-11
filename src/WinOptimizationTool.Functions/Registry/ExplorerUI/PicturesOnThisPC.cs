namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class PicturesOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}"),
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}"),
		};
		return list.ToSingleResult("HidePicturesFromThisPC");
	}
    [NotImplemented]
    public static Result Show()
    {
        throw new NotImplementedException();
    }
}
