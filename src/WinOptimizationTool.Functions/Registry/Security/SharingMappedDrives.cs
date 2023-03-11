namespace WinOptimizationTool.Functions.Registry.Security;

public class SharingMappedDrives : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System","EnableLinkedConnections",1),
		};
		return list.ToSingleResult("EnableSharingMappedDrives");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "EnableLinkedConnections"),
		};
		return list.ToSingleResult("DisableSharingMappedDrives");
	}
}
