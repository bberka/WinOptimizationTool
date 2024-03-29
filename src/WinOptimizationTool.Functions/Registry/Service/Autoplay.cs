namespace WinOptimizationTool.Functions.Registry.Service;

public class Autoplay : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers","DisableAutoplay",1),
		};
		return list.CombineAll("DisableAutoplay");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers","DisableAutoplay",0),
		};
		return list.CombineAll("EnableAutoplay");
	}
}
