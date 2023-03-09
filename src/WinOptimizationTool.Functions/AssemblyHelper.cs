using System.Management.Automation.Language;
using System.Reflection;
using Namotion.Reflection;
using WinOptimizationTool.Core.Attributes;
using WinOptimizationTool.Core.Models;

namespace WinOptimizationTool.Functions;

public static class AssemblyHelper
{
    private static Assembly _assembly;
    public static Assembly GetAssemblyInstance()
    {
        if (_assembly is null) _assembly = Assembly.GetExecutingAssembly();
        return _assembly;
    }

    private const string FuncNameSpace = "WinOptimizationTool.Functions";

	private static readonly string[] _ignoreMethods = new[]
    {
	    "ToString",
	    "GetType",
	    "Equals",
	    "GetHashCode",
    };
    public static List<Function> GetAllMethodsFromAssembly()
    {
        var assembly = GetAssemblyInstance();
        var names = (from type in assembly.GetTypes()
                from method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where type.Namespace?.Contains(FuncNameSpace) == true 
                      && !_ignoreMethods.Contains(method.Name)
                      && type.InheritsFromTypeName(nameof(BaseFunction), TypeNameStyle.Name)
                select new Function(
	                type.FullName + ":" + method.Name,
	                method.GetCustomAttributes(true).OfType<ForeColorAttribute>().FirstOrDefault(),
	                method.GetCustomAttributes(true).OfType<DisplayNameAttribute>().FirstOrDefault(),
	                method.GetCustomAttributes(true).OfType<TranslateKeyAttribute>().FirstOrDefault(),
	                method.GetCustomAttributes(true).OfType<DefaultAttribute>().FirstOrDefault())
                )
            .Distinct()
            .ToList();
        return names;
    }
    public static Result InvokeMethod(string fullName, string methodName)
    {
        var assembly = GetAssemblyInstance();
        var type = assembly.GetType(fullName);
        if (type is null) return Result.Error("Type does not exists: " + fullName);
        var methodInfo = type.GetMethod(methodName);
        if (methodInfo is null) return Result.Error("Method does not exists: " + methodName);
        var instance = Activator.CreateInstance(type);
        var result = methodInfo.Invoke(instance, null) as Result?;
        if (result is null) return Result.Error("Method did not return a result");
        return result.Value;
    }

   
}