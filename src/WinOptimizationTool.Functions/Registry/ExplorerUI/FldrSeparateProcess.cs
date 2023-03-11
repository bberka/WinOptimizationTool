namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class FldrSeparateProcess : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SeparateProcess",1),
		};
		return list.ToSingleResult("EnableFldrSeparateProcess");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","SeparateProcess",0),
		};
		return list.ToSingleResult("DisableFldrSeparateProcess");
	}
}
