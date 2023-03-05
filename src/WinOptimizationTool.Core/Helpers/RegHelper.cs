using EasMe.Logging;
using Microsoft.Win32;
using System.Diagnostics;
using EasMe.Extensions;
using EasMe.Result;

namespace WinOptimizationTool.Core.Helpers;

public class RegHelper
{
    private readonly string _registryPath;
    private readonly RegistryHive _type;
    private static readonly IEasLog logger = EasLogFactory.CreateLogger();
    public RegHelper(string registryPath, RegistryHive type, bool createIfPathNotExists = false)
    {
        _registryPath = registryPath;
        _type = type;

        if (IsRegPathExist()) return;
        if (!createIfPathNotExists) throw new Exception("Path: " + registryPath + " not exists");
        _ = CreatePath();
    }

    public static Result SetDword(RegistryHive type, string path, string key, int value)
    {
        return SetValue(type, path, key, value, RegistryValueKind.DWord);
    }

    public static Result SetString(RegistryHive type, string path, string key, string value)
    {
        return SetValue(type, path, key, value, RegistryValueKind.String);
    }
    public static Result SetValue(RegistryHive type, string path, string key, object value, RegistryValueKind valueKind)
    {
        try
        {
            using var regKey = RegistryKey.OpenBaseKey(type, RegistryView.Default);
            using var subKey = regKey.OpenSubKey(path,true) ?? regKey.CreateSubKey(path, true);
            subKey.SetValue(key, value, valueKind);
            logger.Info($"Successfully updated => Type:{type}|Path:{path}|Key:{key}");
            return Result.Success($"Successfully updated => Type:{type}|Path:{path}|Key:{key}|NewValue:{valueKind}|ValueKind:{valueKind}");
        }
        catch (Exception ex)
        {
            logger.Exception(ex, $"Failed to update => Type:{type}|Path:{path}|Key:{key}|NewValue:{valueKind}|ValueKind:{valueKind}");
            return Result.Error($"Failed to update => Type:{type}|Path:{path}|Key:{key}|NewValue:{valueKind}|ValueKind:{valueKind}");
        }
    }

    public static Result DeleteValue(RegistryHive type, string path, string key)
    {
        try
        {
            using var regKey = RegistryKey.OpenBaseKey(type, RegistryView.Default);
            var subKey = regKey.OpenSubKey(path, true) ?? regKey.CreateSubKey(path, true);
            subKey.DeleteValue(key);
            logger.Info($"Successfully deleted => Type:{type}|Path:{path}|Key:{key}");
            return Result.Success($"Successfully deleted => Type:{type}|Path:{path}|Key:{key}");
        }
        catch (Exception ex)
        {
            logger.Exception(ex, $"Failed to delete => Type:{type}|Path:{path}|Key:{key}");
            return Result.Error($"Failed to delete => Type:{type}|Path:{path}|Key:{key}");
        }
    }
    public static RegHelper CreateLocalMachine(string registryPath, bool createIfPathNotExists = false)
    {
        return new RegHelper(registryPath, RegistryHive.LocalMachine, createIfPathNotExists);
    }

    public static RegHelper CreateCurrentUser(string registryPath, bool createIfPathNotExists = false)
    {
        return new RegHelper(registryPath, RegistryHive.CurrentUser, createIfPathNotExists);
    }
    public static RegHelper CreateClassesRoot(string registryPath, bool createIfPathNotExists = false)
    {
        return new RegHelper(registryPath, RegistryHive.ClassesRoot, createIfPathNotExists);
    }
    public static RegHelper CreateUsers(string registryPath, bool createIfPathNotExists = false)
    {
        return new RegHelper(registryPath, RegistryHive.Users, createIfPathNotExists);
    }
    public static RegHelper CreateCurrentConfig(string registryPath, bool createIfPathNotExists = false)
    {
        return new RegHelper(registryPath, RegistryHive.CurrentConfig, createIfPathNotExists);
    }

    private RegistryKey CreatePath()
    {
        return _type switch
        {
            RegistryHive.LocalMachine => Registry.LocalMachine.CreateSubKey(_registryPath),
            RegistryHive.CurrentUser => Registry.CurrentUser.CreateSubKey(_registryPath),
            //RegistryType.PerformanceData => Registry.PerformanceData.CreateSubKey(_registryPath),
            RegistryHive.ClassesRoot => Registry.ClassesRoot.CreateSubKey(_registryPath),
            RegistryHive.Users => Registry.Users.CreateSubKey(_registryPath),
            RegistryHive.CurrentConfig => Registry.CurrentConfig.CreateSubKey(_registryPath),
            _ => throw new ArgumentOutOfRangeException("RegistryType")
        };
    }
    private RegistryKey? OpenPath(bool writeable = true)
    {
        return _type switch
        {
            RegistryHive.LocalMachine => Registry.LocalMachine.OpenSubKey(_registryPath, writeable),
            RegistryHive.CurrentUser => Registry.CurrentUser.OpenSubKey(_registryPath, writeable),
            //RegistryType.PerformanceData => Registry.PerformanceData.OpenSubKey(_registryPath, true),
            RegistryHive.ClassesRoot => Registry.ClassesRoot.OpenSubKey(_registryPath, writeable),
            RegistryHive.Users => Registry.Users.OpenSubKey(_registryPath, writeable),
            RegistryHive.CurrentConfig => Registry.CurrentConfig.OpenSubKey(_registryPath, writeable),
            _ => throw new ArgumentOutOfRangeException("RegistryType")
        };
    }
    public bool IsRegPathExist()
    {
        using var reg = OpenPath();
        return reg != null;
    }

    public bool IsKeyExist(string regKey)
    {
        using var reg = OpenPath();
        return reg?.GetSubKeyNames().Contains(regKey) ?? false;
    }

    public string? GetValue(string regKey)
    {
        using var reg = OpenPath();
        return reg?.GetValue(regKey)?.ToString();
    }

    public bool DeleteKey(string key)
    {
        using var reg = OpenPath();
        if (reg is null) return false;
        reg.DeleteSubKey(key);
        return true;
    }


    public bool SetValue(string regKey, object regValue)
    {
        using var reg = OpenPath();
        if (reg is null) return false;
        reg.SetValue(regKey, regValue);
        return true;
    }
    public bool SetValue(string regKey, object regValue, RegistryValueKind valueKind)
    {
        using var reg = OpenPath();
        if (reg is null) return false;
        reg.SetValue(regKey, regValue, valueKind);
        return true;
    }

    public bool SetDword(string key, long value)
    {
        return SetValue(key, value, RegistryValueKind.DWord);
    }

    public bool SetString(string key, string value)
    {
        return SetValue(key, value, RegistryValueKind.String);
    }

    public static void Export(string exportPath = "")
    {
        if (exportPath.IsNullOrEmpty())
        {
            exportPath = Path.Combine(Directory.GetCurrentDirectory(), "RegBackups");
            if (!Directory.Exists(exportPath)) Directory.CreateDirectory(exportPath);
        }

        var fileName = $"RegistryBackup_{DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss")}_{Guid.NewGuid()}.reg";
        var cmd1 = $"reg export HKLM \"{Path.Combine(exportPath, $"HKLM_{fileName}")}\"";
        var cmd2 = $"reg export HKCR \"{Path.Combine(exportPath, $"HKCR_{fileName}")}\"";
        var cmd3 = $"reg export HKCU \"{Path.Combine(exportPath, $"HKCU_{fileName}")}\"";
        var cmd4 = $"reg export HKCC \"{Path.Combine(exportPath, $"HKCC_{fileName}")}\"";
        //var cmd5 =  $"reg export HKUS \"{Path.Combine(exportPath,$"HKUS_{fileName}")}\"";

        Process cmd = new Process();
        cmd.StartInfo.FileName = "cmd.exe";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.StartInfo.UseShellExecute = false;
        cmd.Start();

        cmd.StandardInput.WriteLine(cmd1);
        cmd.StandardInput.WriteLine(cmd2);
        cmd.StandardInput.WriteLine(cmd3);
        cmd.StandardInput.WriteLine(cmd4);
        //cmd.StandardInput.WriteLine(cmd5);
        cmd.StandardInput.Flush();
        cmd.StandardInput.Close();
        cmd.WaitForExit();
        //Trace.WriteLine(cmd.StandardOutput.ReadToEnd());
    }


}