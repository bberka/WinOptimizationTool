namespace WinOptimizationTool.Functions.Registry.Network;

public class CurrentNetwork : BaseFunction
{
	public static Result SetPrivate()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-NetConnectionProfile -NetworkCategory Private"),
		};
		return list.ToSingleResult("SetCurrentNetworkPrivate");
	}
	public static Result SetPublic()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-NetConnectionProfile -NetworkCategory Public"),
		};
		return list.ToSingleResult("SetCurrentNetworkPublic");
	}
}
