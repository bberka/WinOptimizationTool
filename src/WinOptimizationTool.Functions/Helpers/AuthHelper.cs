using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace WinOptimizationTool.Functions.Helpers;

public class AuthHelper
{
    public static bool IsElevated => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

    public static void Elevate()
    {
        Environment.Exit(0);
        //if (!IsElevated)
        //{
        //    var processInfo = new ProcessStartInfo(Assembly.GetEntryAssembly()?.Location)
        //    {
        //        Verb = "runas",
        //        UseShellExecute = true
        //    };
        //    Process.Start(processInfo);
        //    Environment.Exit(0);
        //}

    }
}