namespace WinOptimizationTool.Core.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class ShellFunctionAttribute : Attribute
{
	public string FunctionName { get; }

	public ShellFunctionAttribute(string functionName)
	{
		FunctionName = functionName;
	}
	
}