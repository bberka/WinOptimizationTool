using System;
using System.Security.Principal;
using Microsoft.Win32.TaskScheduler;

namespace WinOptimizationTool.Functions.Helpers;

/// <summary>
/// Windows Task Scheduler Helper, requires admin rights
/// </summary>
public static class TaskHelper
{
    /// <summary>
    /// Disables the task with the given path, returns false if the task does not exist
    /// </summary>
    /// <param name="taskPath"></param>
    /// <returns></returns>
    public static bool DisableTask(string taskPath)
    {
       
        var task = TaskService.Instance.GetTask(taskPath);
        if (task == null)
        {
            return false;
        }
        task.Enabled = false;
        task.RegisterChanges();
        return true;
    }

    /// <summary>
    /// Enables the task with the given path, returns false if the task does not exist
    /// </summary>
    /// <param name="taskPath"></param>
    /// <returns></returns>
    public static bool EnableTask(string taskPath)
    {
        var task = TaskService.Instance.GetTask(taskPath);
        if (task == null)
        {
            return false;
        }
        task.Enabled = true;
        task.RegisterChanges();
        return true;
    }
}