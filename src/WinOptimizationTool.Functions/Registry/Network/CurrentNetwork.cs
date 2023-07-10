namespace WinOptimizationTool.Functions.Registry.Network;

public class CurrentNetwork : BaseFunction
{
    [NotImplemented]
    public static Result SetPrivate()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-NetConnectionProfile -NetworkCategory Private"),
		};
		return list.CombineAll("SetCurrentNetworkPrivate");
	}
    [NotImplemented]
    public static Result SetPublic()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-NetConnectionProfile -NetworkCategory Public"),
		};
		return list.CombineAll("SetCurrentNetworkPublic");
	}
}
