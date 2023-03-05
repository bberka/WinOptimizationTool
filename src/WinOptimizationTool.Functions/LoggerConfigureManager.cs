using EasMe.Logging;

namespace WinOptimizationTool.Functions;

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
            x.MinimumLogLevel = LogSeverity.TRACE;
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
            x.MinimumLogLevel = LogSeverity.DEBUG;//TODO: Change to INFO
            x.LogFileName = "WinOptimizationTool_";
        });
    }
}