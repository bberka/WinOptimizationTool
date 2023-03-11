namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class VideosOnThisPC : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{f86fa3ab-70d2-4fc7-9c99-fcbf05467f3a}"),
			RegHelper.DeletePath(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\MyComputer\NameSpace\{A0953C92-50DC-43bf-BE83-3742FED03C9C}"),
		};
		return list.ToSingleResult("HideVideosFromThisPC");
	}
    [NotImplemented]
    public static Result Show()
    {
        throw new NotImplementedException();
    }
}
