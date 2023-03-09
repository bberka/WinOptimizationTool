using System.Drawing;
using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Registery.Privacy;

public class P2P : BaseFunction
{

	[ForeColor(MethodForeColor.Green)]
	[DisplayName("Set P2P Local")]
	public static Result SetP2PUpdateLocal()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",1),
		};
		return list.ToSingleResult("SetP2PUpdateLocal");
	}
	[ForeColor(MethodForeColor.Orange)]
	[DisplayName("Set P2P Internet")]
	public static Result SetP2PUpdateInternet()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",3),
		};
		return list.ToSingleResult("SetP2PUpdateInternet");
	}
	[ForeColor(MethodForeColor.Red)]
	[DisplayName("Set P2P Disable")]
	public static Result SetP2PUpdateDisable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config","DODownloadMode",0),
		};
		return list.ToSingleResult("SetP2PUpdateDisable");
	}

}