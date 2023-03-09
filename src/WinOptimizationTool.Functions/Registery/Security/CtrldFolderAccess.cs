namespace WinOptimizationTool.Functions.Registery.Security;

public class CtrldFolderAccess : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-MpPreference -EnableControlledFolderAccess Enabled -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("EnableCtrldFolderAccess");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Set-MpPreference -EnableControlledFolderAccess Disabled -ErrorAction SilentlyContinue"),
		};
		return list.ToSingleResult("DisableCtrldFolderAccess");
	}
}