using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Functions.Registery.Privacy;

public class Telemetry : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\Software Protection Platform","NoGenTicket",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\SQMClient\Windows","CEIPEnable",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppCompat","AITEnable",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\AppCompat","DisableInventory",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\AppV\CEIP","CEIPEnable",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\TabletPC","PreventHandwritingDataSharing",1),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\TextInput","AllowLinguisticDataCollection",0),
			TaskHelper.DisableTask(@"Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser"),
			TaskHelper.DisableTask(@"Microsoft\Windows\Application Experience\ProgramDataUpdater"),
			TaskHelper.DisableTask(@"Microsoft\Windows\Autochk\Proxy"),
			TaskHelper.DisableTask(@"Microsoft\Windows\Customer Experience Improvement Program\Consolidator"),
			TaskHelper.DisableTask(@"Microsoft\Windows\Customer Experience Improvement Program\UsbCeip"),
			TaskHelper.DisableTask(@"Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector"),
			TaskHelper.DisableTask(@"Microsoft\Office\Office ClickToRun Service Monitor"),
			TaskHelper.DisableTask(@"Microsoft\Office\OfficeTelemetryAgentFallBack2016"),
			TaskHelper.DisableTask(@"Microsoft\Office\OfficeTelemetryAgentLogOn2016"),
		};
		return list.ToSingleResult("DisableTelemetry");
	}

	[Default]
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection","AllowTelemetry",3),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Policies\DataCollection","AllowTelemetry",3),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\PreviewBuilds", "AllowBuildPreview"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows NT\CurrentVersion\Software Protection Platform", "NoGenTicket"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\SQMClient\Windows", "CEIPEnable"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppCompat", "AITEnable"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisableInventory"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\AppV\CEIP", "CEIPEnable"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\TabletPC", "PreventHandwritingDataSharing"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\TextInput", "AllowLinguisticDataCollection"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Application Experience\ProgramDataUpdater"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Autochk\Proxy"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Customer Experience Improvement Program\Consolidator"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Customer Experience Improvement Program\UsbCeip"),
			TaskHelper.EnableTask(@"Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector"),
			TaskHelper.EnableTask(@"Microsoft\Office\Office ClickToRun Service Monitor"),
			TaskHelper.EnableTask(@"Microsoft\Office\OfficeTelemetryAgentFallBack2016"),
			TaskHelper.EnableTask(@"Microsoft\Office\OfficeTelemetryAgentLogOn2016"),
		};
		return list.ToSingleResult("EnableTelemetry");
	}
}