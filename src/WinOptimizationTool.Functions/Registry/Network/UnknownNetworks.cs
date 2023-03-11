namespace WinOptimizationTool.Functions.Registry.Network;

public class UnknownNetworks : BaseFunction
{
    [NotImplemented]
    public static Result SetPrivate()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\010103000F0000F0010000000F0000F0C967A3643C3AD745950DA7859209176EF5B87C875FA20DF21951640E807D7C24","Category",1),
		};
		return list.ToSingleResult("SetUnknownNetworksPrivate");
	}
    [NotImplemented]
    public static Result SetPublic()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\010103000F0000F0010000000F0000F0C967A3643C3AD745950DA7859209176EF5B87C875FA20DF21951640E807D7C24", "Category"),
		};
		return list.ToSingleResult("SetUnknownNetworksPublic");
	}
}
