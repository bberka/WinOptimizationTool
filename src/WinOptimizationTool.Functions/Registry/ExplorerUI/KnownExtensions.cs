namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class KnownExtensions : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideFileExt",0),
		};
		return list.ToSingleResult("ShowKnownExtensions");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","HideFileExt",1),
		};
		return list.ToSingleResult("HideKnownExtensions");
	}
}
