namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class Pictures : BaseFunction
{
    public static Result ShowInExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Show"),
        };
        return list.ToSingleResult("ShowPicturesInExplorer");
    }
    public static Result HideFromExplorer()
    {
        var list = new List<Result>()
        {
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
            RegHelper.SetString(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\{0ddd015d-b06c-45d5-8c4c-f59713854639}\PropertyBag","ThisPCPolicy",@"Hide"),
        };
        return list.ToSingleResult("HidePicturesFromExplorer");
    }
    public static Result HideFromThisPC()
    {
        var list = new List<Result>()
        {
            RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{24ad3ad4-a569-4530-98e1-ab02f9417aa8}"),
            RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3ADD1653-EB32-4cb0-BBD7-DFA0ABB5ACCA}"),
        };
        return list.ToSingleResult("HidePicturesFromThisPC");
    }
}
