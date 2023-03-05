

using EasMe.Logging;

namespace WinOptimizationTool.Core.Helpers;

/// <summary>
/// Windows Task Scheduler Helper, requires admin rights
/// </summary>
public static class TaskHelper
{
    private static readonly IEasLog logger = EasLogFactory.CreateLogger();
    /// <summary>
    /// Disables the task with the given path, returns false if the task does not exist
    /// </summary>
    /// <param name="taskPath"></param>
    /// <returns></returns>
    public static Result DisableTask(string taskPath)
    {
        try
        {
            var task = TaskService.Instance.GetTask(taskPath);
            if (task == null)
            {
                logger.Warn("Task not found : " + taskPath);
                return Result.Warn("Task not found : " + taskPath);
            }
            task.Enabled = false;
            task.RegisterChanges();
            logger.Info($"Successfully disabled task: {taskPath}");
            return Result.Success($"Successfully disabled task: {taskPath}");
        }
        catch (Exception ex)
        {
            logger.Exception(ex, $"Failed to disable task: {taskPath}");
            return Result.Error($"Failed to disable task: {taskPath}");
        }
    }

    /// <summary>
    /// Enables the task with the given path, returns false if the task does not exist
    /// </summary>
    /// <param name="taskPath"></param>
    /// <returns></returns>
    public static Result EnableTask(string taskPath)
    {
        try
        {
            var task = TaskService.Instance.GetTask(taskPath);
            if (task == null)
            {
                logger.Warn("Task not found : " + taskPath);
                return Result.Warn("Task not found : " + taskPath);
            }
            task.Enabled = true;
            task.RegisterChanges();
            logger.Info($"Successfully enabled task: {taskPath}");
            return Result.Success($"Successfully enabled task: {taskPath}");
        }
        catch (Exception ex)
        {
            logger.Exception(ex, $"Failed to enable task: {taskPath}");
            return Result.Error($"Failed to enable task: {taskPath}");
        }
    }
}