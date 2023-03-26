namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class NetworkIconLockScreen : BaseFunction
{
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\System","DontDisplayNetworkSelectionUI",1),
		};
		return list.Combine(true,"HideNetworkFromLockScreen");
	}
    public static Result Show()
    {
        var list = new List<Result>()
        {
            RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\System", "DontDisplayNetworkSelectionUI"),
        };
        return list.Combine(true,"ShowNetworkOnLockScreen");
    }
}
