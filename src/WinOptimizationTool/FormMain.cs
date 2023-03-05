using EasMe.Result;
using System.Diagnostics;
using System.Reflection;
using EasMe.Logging;
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
        private const int BUTTON_WIDTH = 200;
        private const int BUTTON_HEIGHT = 35;
        private const int COL_ROWS = 15;
        private void FormMain_Load(object sender, EventArgs e)
        {
            //RegHelper.Export();
            //var preset = new Preset()
            //{
            //    Name = "Test",
            //    Author = "Kassius",
            //    Functions = methods,
            //};
            //PresetHelper.SavePreset(preset);
            RenderButtons();
        }

        private static readonly IEasLog logger = EasLogFactory.CreateLogger();
        private void RenderButtons()
        {
            var methods = AssemblyHelper.GetAllMethodsFromAssembly().Select(x => new Function(x)).ToList();

            foreach (var item in methods.GroupBy(x => x.FolderName).ToList())
            {
                var tabPage = new TabPage();
                tabPage.Text = item.Key;
                tabPage.Name = Guid.NewGuid().ToString().Replace("-", "");
                var col = 0;
                foreach (var method in item)
                {
                    var button = new Button();
                    button.Name = method.FullName;
                    button.Text = method.MethodName + " " + method.ClassName;
                    button.Size = new Size(BUTTON_WIDTH, BUTTON_HEIGHT);

                    col = tabPage.Controls.Count / COL_ROWS;
                    var count = tabPage.Controls.Count - col * COL_ROWS;
                    var x = 10 + (BUTTON_WIDTH * col);
                    var y = 10 + (BUTTON_HEIGHT * count);
                    button.Location = new Point(x, y);
                    button.Click += (sender, args) =>
                        {
                            try
                            {
                                var result = AssemblyHelper.InvokeMethod(method.ClassNameWithNameSpace, method.MethodName);
                                if (result.IsFailure)
                                {
                                    MessageBox.Show($"An error occured while executing function\n\nError: {result.ErrorCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show($"Function executed successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception e)
                            {
                                logger.Exception(e, "An exception occured while running function : " + ((Button)sender).Name);
                                MessageBox.Show($"An exception occured while executing function\n\nError: {e.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        };
                    tabPage.Controls.Add(button);
                }
                tabControlMain.TabPages.Add(tabPage);

            }



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
                PrintToConsole($"Function Name: {item.Name} => {item.Message}");
                foreach (var item2 in item.Results)
                {
                    PrintToConsole((item2.IsSuccess ? "[SUCCESS]" : "[FAIL]") + $" {item2.ErrorCode}");
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

        private void buttonSavePreset_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewPresetDetails_Click(object sender, EventArgs e)
        {
            var preset = PresetHelper.GetLoadedPreset();
            if (preset is null)
            {
                MessageBox.Show($"Preset is not loaded", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Loaded preset details\n\nName: {preset.Name}\nAuthor: {preset.Author}\nDescription: {preset.Description}\nFunction Count: {preset.Functions.Count}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonClearConsole_Click(object sender, EventArgs e)
        {
            richTextBoxConsole.Clear();
        }
    }
}


//foreach (var method in methods)
//{
//    var button = new Button();
//    button.Name = method.FullName;
//    button.Text = method.MethodName + " " + method.ClassName;
//    button.Size = new Size(BUTTON_WIDTH, BUTTON_HEIGHT);

//    //var mod = panelView.Controls.Count % 10;
//    col = panelView.Controls.Count / COL_ROWS;
//    var count = panelView.Controls.Count - col * COL_ROWS;
//    var x = 10 + (BUTTON_WIDTH * col);
//    var y = 10 + (BUTTON_HEIGHT * count);
//    button.Location = new Point( x,y );
//    button.Click += (sender, args) =>
//    {
//        try
//        {
//            var result = AssemblyHelper.InvokeMethod(method.ClassNameWithNameSpace, method.MethodName);
//            if (result.IsFailure)
//            {
//                MessageBox.Show($"An error occured while executing function\n\nError: {result.ErrorCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            MessageBox.Show($"Function executed successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        catch (Exception e)
//        {
//            logger.Exception(e,"An exception occured while running function : " + ((Button)sender).Name);
//            MessageBox.Show($"An exception occured while executing function\n\nError: {e.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }

//    };
//    panelView.Controls.Add(button);
//}