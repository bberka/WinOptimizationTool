namespace WinOptimizationTool.Core.Attributes;

/// <summary>
/// Indicates that method will set Windows Default settings
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public class DefaultAttribute : Attribute
{
	public DefaultAttribute()
	{
	}

	
}