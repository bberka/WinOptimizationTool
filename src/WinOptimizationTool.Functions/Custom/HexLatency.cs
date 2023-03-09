namespace WinOptimizationTool.Functions.Custom;

public class HexLatency : BaseFunction
{
    public static IReadOnlyCollection<Result> Hex28()
    {
        throw new NotImplementedException();
        var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
        regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }
    public static IReadOnlyCollection<Result> Hex24()
    {
	    throw new NotImplementedException();
	    var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
	    regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }
    public static IReadOnlyCollection<Result> Hex22()
    {
	    throw new NotImplementedException();
	    var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
	    regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }
    public static IReadOnlyCollection<Result> Hex18()
    {
	    throw new NotImplementedException();
	    var regPControl = RegHelper.CreateLocalMachine("SYSTEM\\CurrentControlSet\\Control\\PriorityControl");
	    regPControl.SetDword("Win32PrioritySeparation", 00000028);
    }
}