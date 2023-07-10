using System.Management.Automation;
using EasMe.Logging;
using Microsoft.Extensions.Logging;

namespace WinOptimizationTool.Core;

public static class LoggerConfigureManager
{
    public static void Configure()
    {
        if (System.Diagnostics.Debugger.IsAttached)
        {
            ConfigureDebug();
        }
        else
        {
            ConfigureRelease();
        }
    }

    private static void ConfigureDebug()
    {
        EasLogFactory.Configure(x =>
        {
            x.ConsoleAppender = false;
            x.WebInfoLogging = false;
            x.ExceptionHideSensitiveInfo = false;
            x.MinimumLogLevel = EasLogLevel.Debug;
            x.LogFileName = "WinOptimizationTool_";
        });
    }

    private static void ConfigureRelease()
    {
        EasLogFactory.Configure(x =>
        {
            x.ConsoleAppender = false;
            x.WebInfoLogging = false;
            x.ExceptionHideSensitiveInfo = false;
            x.MinimumLogLevel = EasLogLevel.Information;//TODO: Change to INFO
            x.LogFileName = "WinOptimizationTool_";
        });
    }
}