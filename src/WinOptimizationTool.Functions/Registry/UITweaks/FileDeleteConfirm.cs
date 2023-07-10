namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class FileDeleteConfirm : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer","ConfirmFileDelete",1),
		};
		return list.CombineAll("EnableFileDeleteConfirm");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "ConfirmFileDelete"),
		};
		return list.CombineAll("DisableFileDeleteConfirm");
	}
}
