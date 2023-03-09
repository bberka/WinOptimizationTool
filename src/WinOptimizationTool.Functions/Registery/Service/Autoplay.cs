namespace WinOptimizationTool.Functions.Registery.Service;

public class Autoplay : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers","DisableAutoplay",1),
		};
		return list.ToSingleResult("DisableAutoplay");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers","DisableAutoplay",0),
		};
		return list.ToSingleResult("EnableAutoplay");
	}
}