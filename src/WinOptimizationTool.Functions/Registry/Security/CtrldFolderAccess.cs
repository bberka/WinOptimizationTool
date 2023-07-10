namespace WinOptimizationTool.Functions.Registry.Security;

public class CtrldFolderAccess : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-MpPreference -EnableControlledFolderAccess Enabled -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("EnableCtrldFolderAccess");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Set-MpPreference -EnableControlledFolderAccess Disabled -ErrorAction SilentlyContinue"),
		};
		return list.CombineAll("DisableCtrldFolderAccess");
	}
}
