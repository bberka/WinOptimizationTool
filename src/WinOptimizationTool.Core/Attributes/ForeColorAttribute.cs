using System.Drawing;

namespace WinOptimizationTool.Core.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class ForeColorAttribute : Attribute
{
	public ForeColorAttribute(MethodForeColor color)
	{
		MethodForeColor = color;
	}
	private MethodForeColor MethodForeColor { get; }
	public Color Color => MethodForeColor switch
	{
		MethodForeColor.Red => Color.Red,
		MethodForeColor.Orange => Color.DarkOrange,
		MethodForeColor.Green => Color.Green,
		_ => Color.Black
	};
}