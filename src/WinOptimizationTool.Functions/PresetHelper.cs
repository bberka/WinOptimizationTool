using EasMe.Extensions;
using EasMe.Logging;
using WinOptimizationTool.Core.Models;

namespace WinOptimizationTool.Functions;

public static class PresetHelper
{
    private static readonly IEasLog logger = EasLogFactory.CreateLogger();

    
    private static List<string> FixFunctionList(List<string> functions, out List<string> removed)
    {
        var temp = functions.ToList();
        removed = new List<string>();
        foreach (var function in temp)
        {
            var split = function.Split(':');
            var className = split[0];
            var methodName = split[1];
            var selectedFuncList = functions.Where(x => x.StartsWith(className + ":")).ToList();
            if (selectedFuncList.Count <= 1) continue;
            foreach (var item in selectedFuncList)
            {
                functions.Remove(item);
                removed.Add(item);
            }
        }
        return functions;
    }
    public static Result SavePreset(Preset preset, bool ignoreErrors = false)
    {
        preset.Functions = FixFunctionList(preset.Functions, out var removed);
        if (removed.Count > 0 && !ignoreErrors)
        {
            logger.Error($"Invalid Functions: " + removed.ToJsonString());
            return Result.Error("Function list is not valid please check logs for details");
        }
        var directory = Path.Combine(Directory.GetCurrentDirectory(), "presets");
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
            logger.Info($"Directory does not exists. Created directory {directory}");
        }
        var filePath = Path.Combine(directory, preset.Name + ".json");
        File.WriteAllText(filePath, preset.ToJsonString());
        return Result.Success();
    }
    public static Result LoadPreset(string filePath)
    {
        if (!File.Exists(filePath)) return Result.Warn("File does not exist");
        if (!filePath.EndsWith(".json")) return Result.Warn("File extension must be json");
        var preset = File.ReadAllText(filePath).FromJsonString<Preset>();
        if (preset is null) return Result.Warn("Failed to parse preset file");
        if (preset.Functions.Count == 0) return Result.Warn("Preset does not contain any functions");
        _preset = preset;
        return Result.Success();
    }
    public static void LoadRecommendedPreset()
    {

    }

    
    public static ResultData<List<FunctionResult>> RunLoadedPresetFunctions()
    {
        if (_preset is null) return Result.Warn("Preset is not loaded");
        if (_preset.Functions.Count == 0) return Result.Warn("Preset does not contain any functions");
        _preset.Functions = FixFunctionList(_preset.Functions, out var removed);
        if (removed.Count > 0)
        {
            logger.Warn($"Invalid Functions: " + removed.ToJsonString());
            return Result.Warn("Function list is not valid please check logs for details");
        }
        var results = new List<FunctionResult>();
        foreach (var function in _preset.Functions)
        {
            var split = function.Split(':');
            var className = split[0];
            var methodName = split[1];
            var res = AssemblyHelper.InvokeMethod(className, methodName);
            var fRes = new FunctionResult
            {
                Name = function,
                Result = res,
            };
            results.Add(fRes);
        }
        return results;
    }

    
    private static Preset? _preset;
    public static Preset? GetLoadedPreset()
    {
        return _preset;
    }


}