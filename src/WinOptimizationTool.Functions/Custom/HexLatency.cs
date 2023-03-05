namespace WinOptimizationTool.Functions.Custom;

public class HexLatency : BaseFunction
{
    public static IReadOnlyCollection<Result> Hex28()
    {
        throw new NotImplementedException();
        var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
        regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }

  
}