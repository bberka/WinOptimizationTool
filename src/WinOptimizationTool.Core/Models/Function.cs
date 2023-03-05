using System.Xml.Linq;

namespace WinOptimizationTool.Core.Models;

public class Function
{
    public Function(string fullname)
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

    }
    public string FullName { get; init; }
    public string NameSpaceWithoutClassName { get; init; }
    public string ClassName { get; init; }
    public string ClassNameWithNameSpace { get; init; }
    public string MethodName { get; init; }
    public string FolderName { get; set; }
}