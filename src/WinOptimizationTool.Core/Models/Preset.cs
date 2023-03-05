
namespace WinOptimizationTool.Core.Models;

public class Preset
{
    /// <summary>
    /// Name of the preset
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of the preset
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Author of the preset
    /// </summary>
    public string Author { get; set; } 
    /// <summary>
    /// WinOptimizationTool version that preset is released
    /// </summary>
    public static string Version => Constants.Version;
    public List<string> Functions { get; set; } = new List<string>();


}