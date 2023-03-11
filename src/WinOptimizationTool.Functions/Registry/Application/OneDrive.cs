namespace WinOptimizationTool.Functions.Registry.Application;

public class OneDrive : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\OneDrive","DisableFileSyncNGSC",1),
		};
		return list.ToSingleResult("DisableOneDrive");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC"),
		};
		return list.ToSingleResult("EnableOneDrive");
	}
	[NotImplemented]

	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","Stop-Process -Name \"OneDrive\" -Force -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Start-Sleep -s 2"),
			Result.MultipleErrors("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\SysWOW64\\OneDriveSetup.exe\""),
			Result.MultipleErrors("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\System32\\OneDriveSetup.exe\""),
			Result.MultipleErrors("Not Implemented","Start-Process $onedrive \"/uninstall\" -NoNewWindow -Wait"),
			Result.MultipleErrors("Not Implemented","Start-Sleep -s 2"),
			Result.MultipleErrors("Not Implemented","Stop-Process -Name \"explorer\" -Force -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Start-Sleep -s 2"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path \"$env:USERPROFILE\\OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path \"$env:LOCALAPPDATA\\Microsoft\\OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path \"$env:PROGRAMDATA\\Microsoft OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","Remove-Item -Path \"$env:SYSTEMDRIVE\\OneDriveTemp\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.MultipleErrors("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Wow6432Node\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"),
		};
		return list.ToSingleResult("UninstallOneDrive");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\SysWOW64\\OneDriveSetup.exe\""),
			Result.MultipleErrors("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\System32\\OneDriveSetup.exe\""),
			Result.MultipleErrors("Not Implemented","Start-Process $onedrive -NoNewWindow"),
		};
		return list.ToSingleResult("InstallOneDrive");
	}
}
