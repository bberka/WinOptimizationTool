using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Custom;

public class MenuShowDelayTime : BaseFunction
{
	[ForeColor(MethodForeColor.Red)]
	[DisplayName("Low MenuShowDelayTime")]
	public static Result SetLow()
    {

        throw new NotImplementedException();
        var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
        regDesktop.SetString("MenuShowDelay", "20");
    }
    [Default]
    [ForeColor(MethodForeColor.Green)]
    [DisplayName("High MenuShowDelayTime")]
    public static Result SetHigh()
    {

	    throw new NotImplementedException();
	    var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
	    regDesktop.SetString("MenuShowDelay", "20");
    }
}