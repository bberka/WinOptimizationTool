namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ThreeDObjects : BaseFunction
{
    public static Result Show3InExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag", "ThisPCPolicy"),
            RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag", "ThisPCPolicy"),
        };
        return list.ToSingleResult("Show3DObjectsInExplorer");
    }
    public static Result HideFromThisPC()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{0DB7E03F-FC29-4DC6-9020-FF41B59E513A}"),
		};
		return list.ToSingleResult("Hide3DObjectsFromThisPC");
	}
    public static Result HideFromExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag","ThisPCPolicy",@"Hide"),
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{31C0DD25-9439-4F12-BF41-7FF4EDA38722}\PropertyBag","ThisPCPolicy",@"Hide"),
        };
        return list.ToSingleResult("Hide3DObjectsFromExplorer");
    }
}
