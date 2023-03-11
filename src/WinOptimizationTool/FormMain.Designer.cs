namespace WinOptimizationTool
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPagePreset = new System.Windows.Forms.TabPage();
            this.buttonLoadPreset = new System.Windows.Forms.Button();
            this.buttonRunPreset = new System.Windows.Forms.Button();
            this.buttonLoadRecommendedPreset = new System.Windows.Forms.Button();
            this.buttonViewPresetDetails = new System.Windows.Forms.Button();
            this.buttonSavePreset = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePreset.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPagePreset
            // 
            this.tabPagePreset.Controls.Add(this.buttonLoadPreset);
            this.tabPagePreset.Controls.Add(this.buttonRunPreset);
            this.tabPagePreset.Controls.Add(this.buttonLoadRecommendedPreset);
            this.tabPagePreset.Controls.Add(this.buttonViewPresetDetails);
            this.tabPagePreset.Controls.Add(this.buttonSavePreset);
            this.tabPagePreset.Location = new System.Drawing.Point(4, 26);
            this.tabPagePreset.Name = "tabPagePreset";
            this.tabPagePreset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreset.Size = new System.Drawing.Size(1894, 801);
            this.tabPagePreset.TabIndex = 1;
            this.tabPagePreset.Text = "Preset";
            this.tabPagePreset.UseVisualStyleBackColor = true;
            // 
            // buttonLoadPreset
            // 
            this.buttonLoadPreset.Location = new System.Drawing.Point(8, 22);
            this.buttonLoadPreset.Name = "buttonLoadPreset";
            this.buttonLoadPreset.Size = new System.Drawing.Size(230, 50);
            this.buttonLoadPreset.TabIndex = 0;
            this.buttonLoadPreset.Text = "Load Preset";
            this.buttonLoadPreset.UseVisualStyleBackColor = true;
            this.buttonLoadPreset.Click += new System.EventHandler(this.buttonLoadPreset_Click);
            // 
            // buttonRunPreset
            // 
            this.buttonRunPreset.Location = new System.Drawing.Point(8, 246);
            this.buttonRunPreset.Name = "buttonRunPreset";
            this.buttonRunPreset.Size = new System.Drawing.Size(230, 50);
            this.buttonRunPreset.TabIndex = 0;
            this.buttonRunPreset.Text = "Run Preset";
            this.buttonRunPreset.UseVisualStyleBackColor = true;
            this.buttonRunPreset.Click += new System.EventHandler(this.buttonRunPreset_Click);
            // 
            // buttonLoadRecommendedPreset
            // 
            this.buttonLoadRecommendedPreset.Location = new System.Drawing.Point(8, 356);
            this.buttonLoadRecommendedPreset.Name = "buttonLoadRecommendedPreset";
            this.buttonLoadRecommendedPreset.Size = new System.Drawing.Size(230, 50);
            this.buttonLoadRecommendedPreset.TabIndex = 0;
            this.buttonLoadRecommendedPreset.Text = "Load Recommended Preset";
            this.buttonLoadRecommendedPreset.UseVisualStyleBackColor = true;
            // 
            // buttonViewPresetDetails
            // 
            this.buttonViewPresetDetails.Location = new System.Drawing.Point(8, 134);
            this.buttonViewPresetDetails.Name = "buttonViewPresetDetails";
            this.buttonViewPresetDetails.Size = new System.Drawing.Size(230, 50);
            this.buttonViewPresetDetails.TabIndex = 0;
            this.buttonViewPresetDetails.Text = "View Preset Details";
            this.buttonViewPresetDetails.UseVisualStyleBackColor = true;
            this.buttonViewPresetDetails.Click += new System.EventHandler(this.buttonViewPresetDetails_Click);
            // 
            // buttonSavePreset
            // 
            this.buttonSavePreset.Location = new System.Drawing.Point(8, 78);
            this.buttonSavePreset.Name = "buttonSavePreset";
            this.buttonSavePreset.Size = new System.Drawing.Size(230, 50);
            this.buttonSavePreset.TabIndex = 0;
            this.buttonSavePreset.Text = "Save Preset";
            this.buttonSavePreset.UseVisualStyleBackColor = true;
            this.buttonSavePreset.Click += new System.EventHandler(this.buttonSavePreset_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePreset);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1902, 831);
            this.tabControlMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 831);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinOptimizationTool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabPagePreset.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPagePreset;
        private Button buttonLoadPreset;
        private Button buttonRunPreset;
        private Button buttonLoadRecommendedPreset;
        private Button buttonViewPresetDetails;
        private Button buttonSavePreset;
        private TabControl tabControlMain;
    }
}