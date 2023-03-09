using System.Drawing;
using System.Management.Automation.Language;
using System.Security.Policy;
using System.Xml.Linq;
using WinOptimizationTool.Core.Attributes;

namespace WinOptimizationTool.Core.Models;

public class Function
{

    public Function(string fullname, 
	    ForeColorAttribute? foreColorAttribute, 
	    DisplayNameAttribute? displayNameAttribute, 
	    TranslateKeyAttribute? translateKeyAttribute,
        DefaultAttribute? defaultAttribute
	    )
    {
        FullName = fullname;
        var split = fullname.Split(':');
        var classNameWithNameSpace = split[0];
        var methodName = split[1];
        var lastIndex = classNameWithNameSpace.LastIndexOf(".", StringComparison.Ordinal);
        var className = classNameWithNameSpace[(lastIndex + 1)..];
        var nameSpace = classNameWithNameSpace[..lastIndex];
        ClassName = className;
        NameSpaceWithoutClassName = nameSpace;
        MethodName = methodName;
        ClassNameWithNameSpace = classNameWithNameSpace;
        FolderName = nameSpace.Split('.').Last();
        LanguageKey = translateKeyAttribute?.Key ?? "None";
        DisplayName = displayNameAttribute?.Name ?? MethodName + " " + ClassName;
        Color = foreColorAttribute?.Color ?? MethodName switch
        {
	        "Disable" => Color.Red,
	        "Revert" => Color.Red,
	        "Hide" => Color.Red,
	        "Enable" => Color.Green,
	        "Apply" => Color.Green,
	        "Show" => Color.Green,

	        _ => Color.Black
        };
        IsDefault = defaultAttribute is not null;
    }

    public string FullName { get; init; }
    public string NameSpaceWithoutClassName { get; init; }
    public string ClassName { get; init; }
    public string ClassNameWithNameSpace { get; init; }
    public string MethodName { get; init; }
    public string FolderName { get; init; }
    public Color Color { get; init; }
    public string DisplayName { get; init; }
    public string LanguageKey { get; init; }
    public bool IsDefault { get; init; }
}