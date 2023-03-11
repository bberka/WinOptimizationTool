using EasMe.Result;
using System.Diagnostics;
using System.Reflection;
using EasMe.Extensions;
using EasMe.Logging;
using WinOptimizationTool.Core.Helpers;
using WinOptimizationTool.Core.Models;
using WinOptimizationTool.Functions;
using WinOptimizationTool.Helper;
using WinOptimizationTool.Properties;

namespace WinOptimizationTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private const int BUTTON_WIDTH = 300;
        private const int TOTAL_WIDTH = BUTTON_WIDTH * 2;

        private const int BUTTON_HEIGHT = 35;
        private const int COL_ROWS = 20;
        private const int COL_ROW_LIMIT= 20;

        private void FormMain_Load(object sender, EventArgs e)
        {
            Render();
        }

        private static readonly IEasLog logger = EasLogFactory.CreateLogger();
 
		private void Render()
		{
			var methods = AssemblyHelper.GetAllMethodsFromAssembly().ToList();
			//methods = methods.Where(x => x.ClassName == "P2P" || x.ClassName == "Telemetry").OrderByDescending(x => x.ClassName).ToList();
			foreach (var item in methods.GroupBy(x => x.FolderName).ToList())
			{
				var tabPage = new TabPage();
				tabPage.Text = item.Key;
				tabPage.Name = Guid.NewGuid().ToString().Replace("-", "");
				var col = 0;
				var row = 0;
                var groupByClass = item.GroupBy(x => x.ClassName).ToList();
				foreach (var method in groupByClass)
				{
					var elCount = 0;
					var groupFunctionCount = method.Count();
                    var buttonWidth = TOTAL_WIDTH / groupFunctionCount;

					foreach (var function in method)
					{
						var button = new Button();
						button.Name = function.FullName;
						button.Text = function.DisplayName;
                        if(function.IsDefault) button.Text += " (D)";
						button.Size = new Size(buttonWidth, BUTTON_HEIGHT);
						button.ForeColor = function.Color;
						//col = tabPage.Controls.Count / COL_ROWS;
						var count = tabPage.Controls.Count - col * COL_ROWS;
						var x = 10 + (buttonWidth * elCount) + (TOTAL_WIDTH * col);
						var y = 10 + (BUTTON_HEIGHT * row);
						button.Location = new Point(x, y);
						button.Click += (sender, args) =>
						{
							try
							{
								var result = AssemblyHelper.InvokeMethod(function.ClassNameWithNameSpace, function.MethodName);
								if (result.IsFailure)
								{
                                    MBoxHelper.ShowError(Resource.FuncExecError, function.MethodName, result.ErrorCode);
									return;
								}
                                MBoxHelper.ShowInfo(Resource.FuncExecSuccess);
							}
							catch (Exception e)
							{
								var msg = MBoxHelper.ShowError(Resource.FuncExecError, function.MethodName, e.Message);
								logger.Exception(e, msg);
							}

						};

						elCount++;
						tabPage.Controls.Add(button);
					}
					row++;
					if (row + 1 != COL_ROW_LIMIT) continue;
					row = 0;
					col++;
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
                MBoxHelper.ShowError(Resource.PresetLoadError,presetResult.ErrorCode);
                return;
            }

            var preset = PresetHelper.GetLoadedPreset();
            MBoxHelper.ShowInfo(Resource.PresetLoadedSuccess,preset.Name, preset.Author,preset.Description, preset.Functions.Count);
        }

  

        private void buttonRunPreset_Click(object sender, EventArgs e)
        {
            var preset = PresetHelper.GetLoadedPreset();
            if (preset is null)
            {
                MBoxHelper.ShowWarn(Resource.PresetNotLoaded);
                return;
            }
            var result = PresetHelper.RunLoadedPresetFunctions();
            foreach (var item in result.Data ?? new())
            {
                PrintToConsole($"Function Name: {item.Name} => {item.Result.ErrorCode}");
                PrintToConsole((item.Result.IsSuccess ? "[SUCCESS]" : "[FAIL]") + $" {item.Result.ErrorCode}");
            }
            if (result.IsFailure)
            {
                MBoxHelper.ShowError(Resource.PresetFuncRunError);
                return;
            }
            var anyErrors = result.Data.Any(x => x.Result.IsSuccess == false);
            if (anyErrors)
            {
	            MBoxHelper.ShowError(Resource.PresetFuncRanWithErrors);
                return;
            }
            MBoxHelper.ShowInfo(Resource.PresetFuncRanSuccessfully);
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
                MBoxHelper.ShowWarn(Resource.PresetNotLoaded);
                return;
            }
            MBoxHelper.ShowInfo(Resource.PresetDetails, preset.Name, preset.Author, preset.Description, preset.Functions.Count);

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