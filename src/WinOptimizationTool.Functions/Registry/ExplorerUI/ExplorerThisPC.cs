namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class ExplorerThisPC : BaseFunction
{
	public static Result Set()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","LaunchTo",1),
		};
		return list.ToSingleResult("SetExplorerThisPC");
	}
}
