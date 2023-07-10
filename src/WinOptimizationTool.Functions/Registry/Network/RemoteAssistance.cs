namespace WinOptimizationTool.Functions.Registry.Network;

public class RemoteAssistance : BaseFunction
{
    [NotImplemented]
    public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Remote Assistance","fAllowToGetHelp",0),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"App.Support.QuickAssist*\" } | Remove-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("DisableRemoteAssistance");
	}
    [NotImplemented]
    public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SYSTEM\CurrentControlSet\Control\Remote Assistance","fAllowToGetHelp",1),
			Result.Error("Not Implemented","Get-WindowsCapability -Online | Where-Object { $_.Name -like \"App.Support.QuickAssist*\" } | Add-WindowsCapability -Online | Out-Null"),
		};
		return list.CombineAll("EnableRemoteAssistance");
	}
}
