using System;
using System.Management.Automation;

namespace WinOptimizationTool.Functions.Custom;

public class ServiceTimeout
{
    public static IReadOnlyCollection<Result> SetLow()
    {
        throw new NotImplementedException();
        var regControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control");
        regControl.SetString("WaitToKillServiceTimeout", "200");
    }
    public static IReadOnlyCollection<Result> SetHigh()
    {
        throw new NotImplementedException();
    }
}