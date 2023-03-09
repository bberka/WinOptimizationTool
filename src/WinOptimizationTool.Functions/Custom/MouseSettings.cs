using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Custom;

public class MouseSettings : BaseFunction
{
    public Result Apply()
    {
        throw new NotImplementedException();
        var regMouse = RegHelper.CreateCurrentUser("Control Panel\\Mouse");
        regMouse.SetString("MouseSpeed", "0");
        regMouse.SetString("MouseThreshold1", "0");
        regMouse.SetString("MouseThreshold2", "0");
        regMouse.SetString("MouseSensitivity", "10");
        var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
        regDesktop.SetDword("MouseWheelRouting", 0);
        var regCursors = RegHelper.CreateCurrentUser("Control Panel\\Cursors");
        regCursors.SetDword("ContactVisualization", 0);
        regCursors.SetDword("GestureVisualization", 0);
    }


    [Default]
    [ForeColor(MethodForeColor.Green)]
    public Result Default()
    {
	    throw new NotImplementedException();
	    var regMouse = RegHelper.CreateCurrentUser("Control Panel\\Mouse");
	    regMouse.SetString("MouseSpeed", "0");
	    regMouse.SetString("MouseThreshold1", "0");
	    regMouse.SetString("MouseThreshold2", "0");
	    regMouse.SetString("MouseSensitivity", "10");
	    var regDesktop = RegHelper.CreateCurrentUser("Control Panel\\Desktop");
	    regDesktop.SetDword("MouseWheelRouting", 0);
	    var regCursors = RegHelper.CreateCurrentUser("Control Panel\\Cursors");
	    regCursors.SetDword("ContactVisualization", 0);
	    regCursors.SetDword("GestureVisualization", 0);
    }
}