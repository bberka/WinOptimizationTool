namespace WinOptimizationTool.Functions.Registry.Application;

public class PhotoViewerAssociation : BaseFunction
{
	public static Result Set()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			Result.Error("Not Implemented","ForEach ($type in @(\"Paint.Picture\", \"giffile\", \"jpegfile\", \"pngfile\")) {"),
			
			
		};
		return list.CombineAll("SetPhotoViewerAssociation");
	}
    [NotImplemented]
    public static Result Unset()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Paint.Picture\shell\open"),
			RegHelper.DeleteValue(RegistryHive.ClassesRoot, @"giffile\shell\open", "MuiVerb"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open","CommandId",@"IE.File"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open\command","(Default)",@"`$env:SystemDrive\Program Files\Internet Explorer\iexplore.exe` %1"),
			RegHelper.SetString(RegistryHive.ClassesRoot,@"giffile\shell\open\command","DelegateExecute",@"{17FE9752-0B5A-4665-84CD-569794602F5C}"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"jpegfile\shell\open"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"pngfile\shell\open"),
		};
		return list.CombineAll("UnsetPhotoViewerAssociation");
	}
}
