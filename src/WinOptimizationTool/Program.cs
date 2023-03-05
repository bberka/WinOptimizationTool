using WinOptimizationTool.Functions;
using WinOptimizationTool.Functions.Helpers;

namespace WinOptimizationTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            if(!AuthHelper.IsElevated) AuthHelper.Elevate();
            LoggerConfigureManager.Configure();
            Application.Run(new FormMain());

        }
    }
}