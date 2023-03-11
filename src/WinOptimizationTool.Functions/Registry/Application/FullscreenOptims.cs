namespace WinOptimizationTool.Functions.Registry.Application;

public class FullscreenOptims : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_DXGIHonorFSEWindowsCompatible",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehavior",2),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehaviorMode",2),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_HonorUserFSEBehaviorMode",1),
		};
		return list.ToSingleResult("DisableFullscreenOptims");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_DXGIHonorFSEWindowsCompatible",0),
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"System\GameConfigStore", "GameDVR_FSEBehavior"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_FSEBehaviorMode",0),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"System\GameConfigStore","GameDVR_HonorUserFSEBehaviorMode",0),
		};
		return list.ToSingleResult("EnableFullscreenOptims");
	}
}
