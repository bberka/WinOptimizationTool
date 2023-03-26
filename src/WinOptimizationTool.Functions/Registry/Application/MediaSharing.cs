namespace WinOptimizationTool.Functions.Registry.Application;

public class MediaSharing : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer","PreventLibrarySharing",1),
		};
		return list.Combine(true,"DisableMediaSharing");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\WindowsMediaPlayer", "PreventLibrarySharing"),
		};
		return list.Combine(true,"EnableMediaSharing");
	}
}
