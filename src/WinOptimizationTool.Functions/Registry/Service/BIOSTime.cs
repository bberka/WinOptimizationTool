namespace WinOptimizationTool.Functions.Registry.Service;

public class BIOSTime : BaseFunction
{
	public static Result SetLocal()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SYSTEM\CurrentControlSet\Control\TimeZoneInformation", "RealTimeIsUniversal"),
		};
		return list.Combine(true,"SetBIOSTimeLocal");
	}
    public static Result SetUTC()
    {
        var list = new List<Result>()
        {
            RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\TimeZoneInformation","RealTimeIsUniversal",1),
        };
        return list.Combine(true,"SetBIOSTimeUTC");
    }
}
