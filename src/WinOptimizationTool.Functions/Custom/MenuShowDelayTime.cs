namespace WinOptimizationTool.Functions.Custom;

public class MenuShowDelayTime : BaseFunction
{

    public static IReadOnlyCollection<Result> SetLow()
    {

        throw new NotImplementedException();
        var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
        regDesktop.SetString("MenuShowDelay", "20");
    }
}