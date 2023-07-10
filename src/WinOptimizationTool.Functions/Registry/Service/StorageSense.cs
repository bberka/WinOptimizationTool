namespace WinOptimizationTool.Functions.Registry.Service;

public class StorageSense : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy","01",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy","StoragePoliciesNotified",1),
		};
		return list.CombineAll("EnableStorageSense");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy"),
		};
		return list.CombineAll("DisableStorageSense");
	}
}
