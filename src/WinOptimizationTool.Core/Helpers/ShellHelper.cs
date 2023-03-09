using System.Diagnostics;
using System.Management.Automation;
using EasMe.Extensions;
using EasMe.Logging;

namespace WinOptimizationTool.Core.Helpers;

public class ShellHelper
{
    private readonly string[] _commandStrings;
    private string[] _outputItems;
    private static readonly IEasLog _logger = EasLogFactory.CreateLogger();

    //public ShellHelper(string[] commandStrings)
    //{
    //    _commandStrings = commandStrings;
    //    _outputItems = Array.Empty<string>();
    //}
    public static string[] RunAndGetOutputCommand(string[] commandStrings)
    {
        var shell = new ShellHelper(commandStrings);
        shell.RunCommand();
        return shell.GetOutputItems();
    }
    public ShellHelper(params string[] commands)
    {
        _commandStrings = commands;
        _outputItems = Array.Empty<string>();
    }
    public void RunCommand()
    {
        using var powerShell = PowerShell.Create();
        foreach (var cmd in _commandStrings)
        {
            powerShell.AddScript(cmd);
        }
        // prepare commands - notice we use `Out-String -Stream` to avoid "backing up" the pipeline

        powerShell.AddCommand("Out-String").AddParameter("Stream", true);

        // now prepare a collection for the output, register event handler
        var output = new PSDataCollection<string>();
        output.DataAdded += ProcessOutput;
        powerShell.Streams.Error.DataAdded += HandleError;
        // invoke the command asynchronously - we'll be relying on the event handler to process the output instead of collecting it here
        var asyncToken = powerShell.BeginInvoke<object, string>(null, output);

        if (asyncToken.AsyncWaitHandle.WaitOne())
        {
            //if (powerShell.HadErrors)
            //{
            //    foreach (var errorRecord in powerShell.Streams.Error)
            //    {
            //        // inspect errors here
            //        // alternatively: register an event handler for `powerShell.Streams.Error.DataAdded` event
            //    }
            //}

            // end invocation without collecting output (event handler has already taken care of that)
            powerShell.EndInvoke(asyncToken);
        }

    }

    public string[] GetOutputItems()
    {
        return _outputItems;
    }
    private void ProcessOutput(object? sender, DataAddedEventArgs eventArgs)
    {
        PSDataCollection<string>? collection = sender as PSDataCollection<string>;
        if (collection == null) return;
        var outputItem = collection[eventArgs.Index];
        lock (_outputItems)
        {
            _outputItems = _outputItems.Append(outputItem).ToArray();
        }
        _logger.Debug($"Command: {_commandStrings.ToJsonString()}", $"Output: {outputItem}");
    }

    private void HandleError(object? sender, DataAddedEventArgs eventArgs)
    {
        PSDataCollection<string>? collection = sender as PSDataCollection<string>;
        if (collection == null) return;
        var outputItem = collection[eventArgs.Index];
        _logger.Warn($"Error Occurred While Running Command:  {_commandStrings.ToJsonString()}", $"Output: {outputItem}");
    }
}