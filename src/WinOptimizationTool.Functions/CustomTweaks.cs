using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using WinOptimizationTool.Functions.Helpers;

namespace WinOptimizationTool.Functions;

public static class CustomTweaks
{
    public static void ApplyMouseSettings()
    {
        var regMouse = RegHelper.CreateCurrentUser("Control Panel\\Mouse");
        regMouse.SetString("MouseSpeed","0");
        regMouse.SetString("MouseThreshold1", "0");
        regMouse.SetString("MouseThreshold2", "0");
        regMouse.SetString("MouseSensitivity", "10");
        var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
        regDesktop.SetDword("MouseWheelRouting", 0);
        var regCursors = RegHelper.CreateCurrentUser("Control Panel\\Cursors");
        regCursors.SetDword("ContactVisualization", 0);
        regCursors.SetDword("GestureVisualization", 0);
    }
    public static string SetPowerPlanToHighPerformance()
    {
        var shell = new ShellHelper(@"powercfg -setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        shell.RunCommand();
        return string.Join('\n', shell.GetOutputItems());
    }

    public static string SetPowerPlanToBalanced()
    {
        var shell = new ShellHelper(@"powercfg -setactive a1841308-3541-4fab-bc81-f71556f20b4a");
        shell.RunCommand();
        return string.Join('\n', shell.GetOutputItems());
    }

    public static void SetHexLatencyToLowest()
    {
        var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
        regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }
    public static void SetMenuShowDelayTimeToLow()
    {
        var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
        regDesktop.SetString("MenuShowDelay", "20");
    }
    public static void SetKillServiceTimeoutToLow()
    {
        var regControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control");
        regControl.SetString("WaitToKillServiceTimeout", "200");
    }
    public static void DisableTabletTips()
    {
        var regTabletTip = RegHelper.CreateCurrentUser("Software\\Microsoft\\TabletTip\\1.7");
        regTabletTip.SetDword("EnableAutocorrection", 0);
        regTabletTip.SetDword("EnableSpellchecking", 0);
        regTabletTip.SetDword("EnableTextPrediction", 0);
        regTabletTip.SetDword("EnablePredictionSpaceInsertion", 0);
        regTabletTip.SetDword("EnableDoubleTapSpace", 0);
        regTabletTip.SetDword("EnableInkingWithTouch", 0);
        var regPenWorkspace = RegHelper.CreateCurrentUser("Software\\Microsoft\\Windows\\CurrentVersion\\PenWorkspace");
        regPenWorkspace.SetDword("PenWorkspaceAppSuggestionsEnabled", 0);
      
    }
    public static void ApplyMMCSSTweaks()
    {
        var regHelperProfile = RegHelper.CreateLocalMachine("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile");
        regHelperProfile.SetDword("SystemResponsiveness", 00000000);
        regHelperProfile.SetValue("NetworkThrottlingIndex", Convert.ToInt32("0xffffffff",16), RegistryValueKind.DWord);//4294967295
        var regHelperGame = RegHelper.CreateLocalMachine("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games");
        regHelperGame.SetDword("Affinity", 00000000);
        regHelperGame.SetString("Background Only", "False");
        regHelperGame.SetDword("Clock Rate", 00002710);
        regHelperGame.SetDword("GPU Priority", 00000008);
        regHelperGame.SetDword("Priority", 00000006);
        regHelperGame.SetString("Scheduling Category", "High");
        regHelperGame.SetString("SFIO Priority", "High");
    }
}