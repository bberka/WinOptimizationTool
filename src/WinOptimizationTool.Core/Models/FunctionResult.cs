namespace WinOptimizationTool.Core.Models;

public class FunctionResult
{
    public IReadOnlyCollection<Result> Results { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}