namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Logging
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gLogFile = new MetroFramework.Controls.MetroTile();
            this.lLogFileOptionsDescription = new MetroFramework.Controls.MetroLabel();
            this.xLogLimit = new System.Windows.Forms.CheckBox();
            this.vLogFileOptions = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lLogLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.nLogLimit = new System.Windows.Forms.NumericUpDown();
            this.cLogMode = new MetroFramework.Controls.MetroComboBox();
            this.lLogMode = new MetroFramework.Controls.MetroLabel();
            this.gConsole = new MetroFramework.Controls.MetroTile();
            this.lLogConsoleOptionsDescription = new MetroFramework.Controls.MetroLabel();
            this.vConsoleOptions = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gLogFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLogLimit)).BeginInit();
            this.gConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // gLogFile
            // 
            this.gLogFile.ActiveControl = null;
            this.gLogFile.BackColor = System.Drawing.Color.Gray;
            this.gLogFile.Controls.Add(this.lLogFileOptionsDescription);
            this.gLogFile.Controls.Add(this.xLogLimit);
            this.gLogFile.Controls.Add(this.vLogFileOptions);
            this.gLogFile.Controls.Add(this.lLogLimitUnits);
            this.gLogFile.Controls.Add(this.nLogLimit);
            this.gLogFile.Controls.Add(this.cLogMode);
            this.gLogFile.Controls.Add(this.lLogMode);
            this.gLogFile.Location = new System.Drawing.Point(344, 63);
            this.gLogFile.Name = "gLogFile";
            this.gLogFile.Size = new System.Drawing.Size(315, 423);
            this.gLogFile.TabIndex = 3;
            this.gLogFile.TabStop = false;
            this.gLogFile.Text = "Log File";
            this.gLogFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.gLogFile.UseSelectable = true;
            // 
            // lLogFileOptionsDescription
            // 
            this.lLogFileOptionsDescription.AutoSize = true;
            this.lLogFileOptionsDescription.Location = new System.Drawing.Point(27, 22);
            this.lLogFileOptionsDescription.Name = "lLogFileOptionsDescription";
            this.lLogFileOptionsDescription.Size = new System.Drawing.Size(227, 38);
            this.lLogFileOptionsDescription.TabIndex = 0;
            this.lLogFileOptionsDescription.Text = "Types of messages that will be written\r\nto the log file on disk.";
            // 
            // xLogLimit
            // 
            this.xLogLimit.AutoSize = true;
            this.xLogLimit.Enabled = false;
            this.xLogLimit.Location = new System.Drawing.Point(18, 390);
            this.xLogLimit.Name = "xLogLimit";
            this.xLogLimit.Size = new System.Drawing.Size(76, 15);
            this.xLogLimit.TabIndex = 4;
            this.xLogLimit.Text = "Only keep";
            // 
            // vLogFileOptions
            // 
            this.vLogFileOptions.CheckBoxes = true;
            this.vLogFileOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.vLogFileOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vLogFileOptions.FullRowSelect = true;
            this.vLogFileOptions.GridLines = true;
            this.vLogFileOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vLogFileOptions.Location = new System.Drawing.Point(78, 59);
            this.vLogFileOptions.Name = "vLogFileOptions";
            this.vLogFileOptions.OwnerDraw = true;
            this.vLogFileOptions.ShowItemToolTips = true;
            this.vLogFileOptions.Size = new System.Drawing.Size(161, 294);
            this.vLogFileOptions.TabIndex = 1;
            this.vLogFileOptions.UseCompatibleStateImageBehavior = false;
            this.vLogFileOptions.UseSelectable = true;
            this.vLogFileOptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 157;
            // 
            // lLogLimitUnits
            // 
            this.lLogLimitUnits.AutoSize = true;
            this.lLogLimitUnits.Location = new System.Drawing.Point(166, 391);
            this.lLogLimitUnits.Name = "lLogLimitUnits";
            this.lLogLimitUnits.Size = new System.Drawing.Size(143, 19);
            this.lLogLimitUnits.TabIndex = 6;
            this.lLogLimitUnits.Text = "of most recent log files";
            // 
            // nLogLimit
            // 
            this.nLogLimit.Enabled = false;
            this.nLogLimit.Location = new System.Drawing.Point(104, 389);
            this.nLogLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nLogLimit.Name = "nLogLimit";
            this.nLogLimit.Size = new System.Drawing.Size(56, 20);
            this.nLogLimit.TabIndex = 5;
            // 
            // cLogMode
            // 
            this.cLogMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cLogMode.FormattingEnabled = true;
            this.cLogMode.ItemHeight = 23;
            this.cLogMode.Items.AddRange(new object[] {
            "One long file",
            "Multiple files, split by session",
            "Multiple files, split by day"});
            this.cLogMode.Location = new System.Drawing.Point(104, 360);
            this.cLogMode.Name = "cLogMode";
            this.cLogMode.Size = new System.Drawing.Size(185, 29);
            this.cLogMode.TabIndex = 3;
            this.cLogMode.UseSelectable = true;
            // 
            // lLogMode
            // 
            this.lLogMode.AutoSize = true;
            this.lLogMode.Location = new System.Drawing.Point(35, 363);
            this.lLogMode.Name = "lLogMode";
            this.lLogMode.Size = new System.Drawing.Size(70, 19);
            this.lLogMode.TabIndex = 2;
            this.lLogMode.Text = "Log mode";
            // 
            // gConsole
            // 
            this.gConsole.ActiveControl = null;
            this.gConsole.Controls.Add(this.lLogConsoleOptionsDescription);
            this.gConsole.Controls.Add(this.vConsoleOptions);
            this.gConsole.Location = new System.Drawing.Point(23, 63);
            this.gConsole.Name = "gConsole";
            this.gConsole.Size = new System.Drawing.Size(315, 423);
            this.gConsole.TabIndex = 2;
            this.gConsole.TabStop = false;
            this.gConsole.Text = "Console";
            this.gConsole.UseSelectable = true;
            // 
            // lLogConsoleOptionsDescription
            // 
            this.lLogConsoleOptionsDescription.AutoSize = true;
            this.lLogConsoleOptionsDescription.Location = new System.Drawing.Point(9, 21);
            this.lLogConsoleOptionsDescription.Name = "lLogConsoleOptionsDescription";
            this.lLogConsoleOptionsDescription.Size = new System.Drawing.Size(227, 38);
            this.lLogConsoleOptionsDescription.TabIndex = 0;
            this.lLogConsoleOptionsDescription.Text = "Types of messages that will be written\r\ndirectly to console.";
            // 
            // vConsoleOptions
            // 
            this.vConsoleOptions.CheckBoxes = true;
            this.vConsoleOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.vConsoleOptions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vConsoleOptions.FullRowSelect = true;
            this.vConsoleOptions.GridLines = true;
            this.vConsoleOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vConsoleOptions.Location = new System.Drawing.Point(76, 59);
            this.vConsoleOptions.Name = "vConsoleOptions";
            this.vConsoleOptions.OwnerDraw = true;
            this.vConsoleOptions.ShowItemToolTips = true;
            this.vConsoleOptions.Size = new System.Drawing.Size(161, 294);
            this.vConsoleOptions.TabIndex = 1;
            this.vConsoleOptions.UseCompatibleStateImageBehavior = false;
            this.vConsoleOptions.UseSelectable = true;
            this.vConsoleOptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 157;
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 502);
            this.Controls.Add(this.gLogFile);
            this.Controls.Add(this.gConsole);
            this.Name = "Logging";
            this.Text = "Logging";
            this.gLogFile.ResumeLayout(false);
            this.gLogFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLogLimit)).EndInit();
            this.gConsole.ResumeLayout(false);
            this.gConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile gLogFile;
        internal MetroFramework.Controls.MetroLabel lLogFileOptionsDescription;
        internal System.Windows.Forms.CheckBox xLogLimit;
        internal MetroFramework.Controls.MetroListView vLogFileOptions;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal MetroFramework.Controls.MetroLabel lLogLimitUnits;
        internal System.Windows.Forms.NumericUpDown nLogLimit;
        internal MetroFramework.Controls.MetroComboBox cLogMode;
        internal MetroFramework.Controls.MetroLabel lLogMode;
        internal MetroFramework.Controls.MetroTile gConsole;
        internal MetroFramework.Controls.MetroLabel lLogConsoleOptionsDescription;
        internal MetroFramework.Controls.MetroListView vConsoleOptions;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
    }
}