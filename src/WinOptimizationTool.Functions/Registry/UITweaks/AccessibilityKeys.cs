namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class AccessibilityKeys : BaseFunction
{
	public static Result Disable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\StickyKeys","Flags",@"506"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\ToggleKeys","Flags",@"58"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\Keyboard Response","Flags",@"122"),
		};
		return list.ToSingleResult("DisableAccessibilityKeys");
	}
	public static Result Enable()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\StickyKeys","Flags",@"510"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\ToggleKeys","Flags",@"62"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Accessibility\Keyboard Response","Flags",@"126"),
		};
		return list.ToSingleResult("EnableAccessibilityKeys");
	}
}
