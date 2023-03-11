namespace WinOptimizationTool.Functions.Registry.UITweaks;

public class ENKeyboard : BaseFunction
{

    [DisplayName("Add EN Keyboard")]
    public static Result Add()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$langs = Get-WinUserLanguageList"),
			Result.MultipleErrors("Not Implemented","$langs.Add(\"en-US\")"),
			Result.MultipleErrors("Not Implemented","Set-WinUserLanguageList $langs -Force"),
		};
		return list.ToSingleResult("AddENKeyboard");
	}
	[DisplayName("Remove EN Keyboard")]
	public static Result Remove()
	{
		var list = new List<Result>()
		{
			Result.MultipleErrors("Not Implemented","$langs = Get-WinUserLanguageList"),
			Result.MultipleErrors("Not Implemented","Set-WinUserLanguageList ($langs | Where-Object {$_.LanguageTag -ne \"en-US\"}) -Force"),
		};
		return list.ToSingleResult("RemoveENKeyboard");
	}
}
