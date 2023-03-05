using System.Diagnostics;
using WinOptimizationTool.Core.Helpers;
using WinOptimizationTool.Core.Models;
using WinOptimizationTool.Functions;

namespace WinOptimizationTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //RegHelper.Export();
            //var methods = AssemblyHelper.GetAllMethodsFromAssembly();
            //var preset = new Preset()
            //{
            //    Name = "Test",
            //    Author = "Kassius",
            //    Functions = methods,
            //};
            //PresetHelper.SavePreset(preset);
        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog()
            {
                Filter = "Preset files (*.json)|*.json",
                Title = "Select a preset file",
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WinOptimizationTool", "Presets")
            };
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var presetResult = PresetHelper.LoadPreset(fileDialog.FileName);
            if (presetResult.IsFailure)
            {
                MessageBox.Show($"An error occured while loading preset\n\nError: {presetResult.ErrorCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var preset = PresetHelper.GetLoadedPreset();
            MessageBox.Show($"Preset loaded!\n\nName: {preset.Name}\nAuthor: {preset.Author}\nDescription: {preset.Description}\nFunction Count: {preset.Functions.Count}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonViewLoadedPresetDetails_Click(object sender, EventArgs e)
        {
            var preset = PresetHelper.GetLoadedPreset();
            if (preset is null)
            {
                MessageBox.Show($"Preset is not loaded", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Loaded preset details\n\nName: {preset.Name}\nAuthor: {preset.Author}\nDescription: {preset.Description}\nFunction Count: {preset.Functions.Count}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonRunPreset_Click(object sender, EventArgs e)
        {
            var preset = PresetHelper.GetLoadedPreset();
            if (preset is null)
            {
                MessageBox.Show($"Preset is not loaded", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = PresetHelper.RunLoadedPresetFunctions();
            foreach (var item in result.Data ?? new())
            {
                PrintToConsole($"IsSuccess: {item.IsSuccess} Function Name: {item.Name} Message: {item.Message}");
                foreach (var item2 in item.Results)
                {
                    PrintToConsole($"IsSuccess: {item2.IsSuccess} Message: {item2.ErrorCode}");
                }
            }
            if (result.IsFailure)
            {
                MessageBox.Show($"An error occured while running preset functions\n\nCheck console and logs for details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var anyErrors = result.Data.Any(x => x.IsSuccess == false);
            if (anyErrors)
            {
                MessageBox.Show($"Preset functions ran with errors!\n\nCheck console and logs for details", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Preset functions ran successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintToConsole(string lineMessage)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxConsole.Text))
            {
                richTextBoxConsole.AppendText(Environment.NewLine + lineMessage);
            }
            else
            {
                richTextBoxConsole.AppendText(lineMessage);
            }
            richTextBoxConsole.ScrollToCaret();
        }
    }
}