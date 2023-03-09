using EasMe.Extensions;
using WinOptimizationTool.Properties;

namespace WinOptimizationTool.Helper;

/// <summary>
/// Simple MessageBox helper static class
/// </summary>
public static class MBoxHelper
{
	public static void ShowError(string message)
	{
		MessageBox.Show(message, Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
	}

	public static string ShowError(string message, params object[] args)
	{
		var msg = message.FormatString(args);
		MessageBox.Show(msg, Resource.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
		return msg;
	}
	public static void ShowWarn(string message)
	{
		MessageBox.Show(message, Resource.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);

	}

	public static string ShowWarn(string message, params object[] args)
	{
		var msg = message.FormatString(args);
		MessageBox.Show(msg, Resource.Warn, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		return msg;
	}
	public static void ShowInfo(string message)
	{
		MessageBox.Show(message, Resource.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
	public static string ShowInfo(string message,params object[] args)
	{
		var msg = message.FormatString(args);
		MessageBox.Show(msg, Resource.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
		return msg;
	}
}