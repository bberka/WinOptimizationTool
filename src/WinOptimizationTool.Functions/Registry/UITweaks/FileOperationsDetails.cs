namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class FileOperationsDetails : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager","EnthusiastMode",1),
		};
		return list.Combine(true,"ShowFileOperationsDetails");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager", "EnthusiastMode"),
		};
		return list.Combine(true,"HideFileOperationsDetails");
	}
}
