namespace WinOptimizationTool.Functions.Registry.Service;

public class RecycleBin : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer","NoRecycleFiles",1),
		};
		return list.CombineAll("DisableRecycleBin");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecycleFiles"),
		};
		return list.CombineAll("EnableRecycleBin");
	}
}
