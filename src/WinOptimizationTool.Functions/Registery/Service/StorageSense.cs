namespace WinOptimizationTool.Functions.Registery.Service;

public class StorageSense : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy","01",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy","StoragePoliciesNotified",1),
		};
		return list.ToSingleResult("EnableStorageSense");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Remove-Item -Path \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\StorageSense\\Parameters\\StoragePolicy\" -Recurse -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("DisableStorageSense");
	}
}