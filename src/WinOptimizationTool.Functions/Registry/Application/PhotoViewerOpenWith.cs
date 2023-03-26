namespace WinOptimizationTool.Functions.Registry.Application;

public class PhotoViewerOpenWith : BaseFunction
{
    [NotImplemented]
    public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Applications\photoviewer.dll\shell\open","MuiVerb",@"@photoviewer.dll,-3043"),
			
			RegHelper.SetString(RegistryHive.ClassesRoot,@"Applications\photoviewer.dll\shell\open\DropTarget","Clsid",@"{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}"),
		};
		return list.Combine(true,"AddPhotoViewerOpenWith");
	}
    [NotImplemented]
    public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Applications\photoviewer.dll\shell\open"),
		};
		return list.Combine(true,"RemovePhotoViewerOpenWith");
	}
}
