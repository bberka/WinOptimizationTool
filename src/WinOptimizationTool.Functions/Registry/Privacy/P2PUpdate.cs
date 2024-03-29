namespace WinOptimizationTool.Functions.Registry.Privacy;

public class P2PUpdate : BaseFunction
{
	public static Result SetLocal()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","# Method used in 1507"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",1),
		};
		return list.CombineAll("SetP2PUpdateLocal");
	}
	public static Result SetDisable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","# Method used in 1507"),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",0),
		};
		return list.CombineAll("SetP2PUpdateDisable");
	}
    public static Result SetInternet()
    {
        var list = new List<Result>()
        {
            Result.Error("Not Implemented","# Method used in 1507"),
            RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",3),
        };
        return list.CombineAll("SetP2PUpdateInternet");
    }
}
