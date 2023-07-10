namespace WinOptimizationTool.Functions.Registry.Application;

public class OneDrive : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\OneDrive","DisableFileSyncNGSC",1),
		};
		return list.CombineAll("DisableOneDrive");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC"),
		};
		return list.CombineAll("EnableOneDrive");
	}
	[NotImplemented]

	public static Result Uninstall()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","Stop-Process -Name \"OneDrive\" -Force -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","Start-Sleep -s 2"),
			Result.Error("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\SysWOW64\\OneDriveSetup.exe\""),
			Result.Error("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\System32\\OneDriveSetup.exe\""),
			Result.Error("Not Implemented","Start-Process $onedrive \"/uninstall\" -NoNewWindow -Wait"),
			Result.Error("Not Implemented","Start-Sleep -s 2"),
			Result.Error("Not Implemented","Stop-Process -Name \"explorer\" -Force -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","Start-Sleep -s 2"),
			Result.Error("Not Implemented","Remove-Item -Path \"$env:USERPROFILE\\OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","Remove-Item -Path \"$env:LOCALAPPDATA\\Microsoft\\OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","Remove-Item -Path \"$env:PROGRAMDATA\\Microsoft OneDrive\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","Remove-Item -Path \"$env:SYSTEMDRIVE\\OneDriveTemp\" -Force -Recurse -ErrorAction SilentlyContinue"),
			Result.Error("Not Implemented","New-PSDrive -Name \"HKCR\" -PSProvider \"Registry\" -Root \"HKEY_CLASSES_ROOT\" | Out-Null"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"),
			RegHelper.DeletePath(RegistryHive.ClassesRoot, @"Wow6432Node\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}"),
		};
		return list.CombineAll("UninstallOneDrive");
	}
    [NotImplemented]
    public static Result Install()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\SysWOW64\\OneDriveSetup.exe\""),
			Result.Error("Not Implemented","$onedrive = \"$env:SYSTEMROOT\\System32\\OneDriveSetup.exe\""),
			Result.Error("Not Implemented","Start-Process $onedrive -NoNewWindow"),
		};
		return list.CombineAll("InstallOneDrive");
	}
}
