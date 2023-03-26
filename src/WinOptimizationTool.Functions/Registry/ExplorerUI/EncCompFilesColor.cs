namespace WinOptimizationTool.Functions.Registry.ExplorerUI;

public class EncCompFilesColor : BaseFunction
{
	public static Result Show()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ShowEncryptCompressedColor",1),
		};
		return list.Combine(true,"ShowEncCompFilesColor");
	}
	public static Result Hide()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowEncryptCompressedColor"),
		};
		return list.Combine(true,"HideEncCompFilesColor");
	}
}
