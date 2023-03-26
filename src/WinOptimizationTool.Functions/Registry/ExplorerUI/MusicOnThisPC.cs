namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class MusicOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{3dfdf296-dbec-4fb4-81d1-6a3438bcf4de}"),
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{1CF1260C-4DD0-4ebb-811F-33C572699FDE}"),
		};
		return list.Combine(true,"HideMusicFromThisPC");
	}
    [NotImplemented]
    public static Result Show()
    {
        throw new NotImplementedException();
    }
}
