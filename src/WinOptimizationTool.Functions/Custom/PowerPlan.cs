using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Custom;

public class PowerPlan : BaseFunction
{

    [ForeColor(MethodForeColor.Green)]
    [DisplayName("Set Performance PowerPlan")]
	public Result HighPerformance()
    {
        throw new NotImplementedException();
        var shell = new ShellHelper(@"powercfg -setactive 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c");
        shell.RunCommand();
        //return string.Join('\n', shell.GetOutputItems());
    }
    [ForeColor(MethodForeColor.Orange)]
    [DisplayName("Set Balanced PowerPlan")]
    [Default]
	public Result Balanced()
    {
        throw new NotImplementedException();
        var shell = new ShellHelper(@"powercfg -setactive a1841308-3541-4fab-bc81-f71556f20b4a");
        shell.RunCommand();
        //return string.Join('\n', shell.GetOutputItems());
    }

	[ForeColor(MethodForeColor.Red)]
	[DisplayName("Set PowerSaver PowerPlan")]
	public Result PowerSaver()
	{
		throw new NotImplementedException();
		var shell = new ShellHelper(@"powercfg -setactive a1841308-3541-4fab-bc81-f71556f20b4a");
		shell.RunCommand();
		//return string.Join('\n', shell.GetOutputItems());
	}
}