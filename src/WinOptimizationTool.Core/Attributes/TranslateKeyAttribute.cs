namespace WinOptimizationTool.Core.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class TranslateKeyAttribute : Attribute
{
	public TranslateKeyAttribute(string key)
	{
		Key = key;
	}
	public string Key { get; }
}
