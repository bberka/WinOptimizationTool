using System.Management.Automation.Language;
using System.Reflection;
using Namotion.Reflection;
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
    public static List<string> GetAllMethodsFromAssembly()
    {
        var assembly = GetAssemblyInstance();
        var names = (from type in assembly.GetTypes()
                from method in type.GetMethods(
                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
                where type.Namespace?.Contains("WinOptimizationTool.Functions") == true 
                      //&& method.Name != "GetAllMethodsFromAssembly"
                      && method.Name != "ToString"
                      && method.Name != "GetType"
                      && method.Name != "Equals"
                      && method.Name != "GetHashCode"
                      && type.InheritsFromTypeName(nameof(BaseFunction), TypeNameStyle.Name)
                select type.FullName + ":" + method.Name)
            .Distinct()
            .ToList();
        return names;
    }
    public static ResultData<IReadOnlyCollection<Result>> InvokeMethod(string fullName, string methodName)
    {
        var assembly = GetAssemblyInstance();
        var type = assembly.GetType(fullName);
        if (type is null) return Result.Error("Type does not exists: " + fullName);
        var methodInfo = type.GetMethod(methodName);
        if (methodInfo is null) return Result.Error("Method does not exists: " + methodName);
        var instance = Activator.CreateInstance(type);
        var result = methodInfo.Invoke(instance, null) as IReadOnlyCollection<Result>;
        return ResultData<IReadOnlyCollection<Result>>.Success(result);
    }

   
}