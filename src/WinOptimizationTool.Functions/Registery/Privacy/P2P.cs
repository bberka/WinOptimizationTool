using System.Drawing;
using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Registery.Privacy;

public class P2P : BaseFunction
{
	[ForeColor(MethodForeColor.Green)]
	[DisplayName("Set P2P Local")]
	public static Result SetUpdateLocal()
    {
        throw new NotImplementedException();

    }
	[ForeColor(MethodForeColor.Orange)]
	[DisplayName("Set P2P Internet")]
	public static Result SetUpdateInternet()
    {
        throw new NotImplementedException();

    }
    [ForeColor(MethodForeColor.Red)]
    [DisplayName("Set P2P Disable")]
	public static Result SetUpdateDisable()
    {
        throw new NotImplementedException();

    }
  

}