namespace WinOptimizationTool.Functions.Registry.Privacy;

public class Feedback : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Siuf\Rules","NumberOfSIUFInPeriod",0),
			RegHelper.SetDword(RegistryHive.LocalMachine,@"SOFTWARE\Policies\Microsoft\Windows\DataCollection","DoNotShowFeedbackNotifications",1),
			TaskHelper.DisableTask(@"Microsoft\Windows\Feedback\Siuf\DmClient"),
			TaskHelper.DisableTask(@"Microsoft\Windows\Feedback\Siuf\DmClientOnScenarioDownload"),
		};
		return list.CombineAll("DisableFeedback");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeleteValue(RegistryHive.CurrentUser, @"Software\Microsoft\Siuf\Rules", "NumberOfSIUFInPeriod"),
			RegHelper.DeleteValue(RegistryHive.LocalMachine, @"SOFTWARE\Policies\Microsoft\Windows\DataCollection", "DoNotShowFeedbackNotifications"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Feedback\Siuf\DmClient"),
			TaskHelper.EnableTask(@"Microsoft\Windows\Feedback\Siuf\DmClientOnScenarioDownload"),
		};
		return list.CombineAll("EnableFeedback");
	}
}
