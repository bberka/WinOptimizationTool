namespace WinOptimizationTool.Functions.Registry.UWPPrivacy;

public class UWPSwapFile : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			
		};
		return list.ToSingleResult("DisableUWPSwapFile");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "SwapfileControl"),
		};
		return list.ToSingleResult("EnableUWPSwapFile");
	}
}
