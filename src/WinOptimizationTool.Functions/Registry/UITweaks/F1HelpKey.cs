namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class F1HelpKey : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			
			
		};
		return list.Combine(true,"DisableF1HelpKey");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.DeletePath(RegistryHive.CurrentUser, @"Software\Classes\TypeLib\{8cec5860-07a1-11d9-b15e-000d56bfe6ee}\1.0\0"),
		};
		return list.Combine(true,"EnableF1HelpKey");
	}
}
