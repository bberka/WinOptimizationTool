namespace WinOptimizationTool.Core.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class DisplayNameAttribute : Attribute
{
	public DisplayNameAttribute(string name)
	{
		Name = name;
	}
	public string Name { get; }
}
	
