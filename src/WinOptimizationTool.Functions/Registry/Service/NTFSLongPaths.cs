namespace WinOptimizationTool.Functions.Registry.Service;

public class NTFSLongPaths : BaseFunction
{
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\FileSystem","LongPathsEnabled",1),
		};
		return list.CombineAll("EnableNTFSLongPaths");
	}
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\FileSystem","LongPathsEnabled",0),
		};
		return list.CombineAll("DisableNTFSLongPaths");
	}
}
