namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class VisualFX : BaseFunction
{
	[ForeColor(MethodForeColor.Green)]
	public static Result Appearence()
	{
		var list = new List<Result>()
		{
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","DragFullWindows",@"1"),
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","MenuShowDelay",@"400"),
			
			RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop\WindowMetrics","MinAnimate",@"1"),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Keyboard","KeyboardDelay",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewAlphaSelect",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewShadow",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarAnimations",1),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects","VisualFXSetting",3),
			RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","EnableAeroPeek",1),
		};
		return list.Combine(true,"SetVisualFXAppearance");
	}
    [ForeColor(MethodForeColor.Orange)]
    public static Result Performance()
    {
        var list = new List<Result>()
        {
            RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","DragFullWindows",@"0"),
            RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop","MenuShowDelay",@"0"),

            RegHelper.SetString(RegistryHive.CurrentUser,@"Control Panel\Desktop\WindowMetrics","MinAnimate",@"0"),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Control Panel\Keyboard","KeyboardDelay",0),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewAlphaSelect",0),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","ListviewShadow",0),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced","TaskbarAnimations",0),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects","VisualFXSetting",3),
            RegHelper.SetDword(RegistryHive.CurrentUser,@"Software\Microsoft\Windows\DWM","EnableAeroPeek",0),
        };
        return list.Combine(true,"SetVisualFXPerformance");
    }
}

