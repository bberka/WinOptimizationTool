namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class NetworkOnExplorer : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum","{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}",1),
		};
		return list.CombineAll("HideNetworkFromExplorer");
	}
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\NonEnum", "{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}"),
		};
		return list.CombineAll("ShowNetworkInExplorer");
	}
}
