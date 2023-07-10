namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ENKeyboard : BaseFunction
{

    [DisplayName("Add EN Keyboard")]
    public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$langs = Get-WinUserLanguageList"),
			Result.Error("Not Implemented","$langs.Add(\"en-US\")"),
			Result.Error("Not Implemented","Set-WinUserLanguageList $langs -Force"),
		};
		return list.CombineAll("AddENKeyboard");
	}
	[DisplayName("Remove EN Keyboard")]
	public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.Error("Not Implemented","$langs = Get-WinUserLanguageList"),
			Result.Error("Not Implemented","Set-WinUserLanguageList ($langs | Where-Object {$_.LanguageTag -ne \"en-US\"}) -Force"),
		};
		return list.CombineAll("RemoveENKeyboard");
	}
}
