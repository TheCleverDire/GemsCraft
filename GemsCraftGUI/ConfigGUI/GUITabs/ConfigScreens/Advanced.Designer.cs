namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Advanced
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
            this.xAutoRank = new System.Windows.Forms.CheckBox();
            this.nMaxUndoStates = new System.Windows.Forms.NumericUpDown();
            this.lMaxUndoStates = new MetroFramework.Controls.MetroLabel();
            this.lIPWarning = new MetroFramework.Controls.MetroLabel();
            this.tIP = new MetroFramework.Controls.MetroTextBox();
            this.xIP = new System.Windows.Forms.CheckBox();
            this.lConsoleName = new MetroFramework.Controls.MetroLabel();
            this.tConsoleName = new MetroFramework.Controls.MetroTextBox();
            this.nMaxUndo = new System.Windows.Forms.NumericUpDown();
            this.lMaxUndoUnits = new MetroFramework.Controls.MetroLabel();
            this.xMaxUndo = new System.Windows.Forms.CheckBox();
            this.xRelayAllBlockUpdates = new System.Windows.Forms.CheckBox();
            this.xNoPartialPositionUpdates = new System.Windows.Forms.CheckBox();
            this.lAdvancedWarning = new MetroFramework.Controls.MetroLabel();
            this.xLowLatencyMode = new System.Windows.Forms.CheckBox();
            this.lProcessPriority = new MetroFramework.Controls.MetroLabel();
            this.cProcessPriority = new MetroFramework.Controls.MetroComboBox();
            this.nTickInterval = new System.Windows.Forms.NumericUpDown();
            this.lTickIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.lTickInterval = new MetroFramework.Controls.MetroLabel();
            this.nThrottling = new System.Windows.Forms.NumericUpDown();
            this.lThrottling = new MetroFramework.Controls.MetroLabel();
            this.lThrottlingUnits = new MetroFramework.Controls.MetroLabel();
            this.gPerformance = new MetroFramework.Controls.MetroTile();
            this.gAdvancedMisc = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndoStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTickInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nThrottling)).BeginInit();
            this.gPerformance.SuspendLayout();
            this.gAdvancedMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // xAutoRank
            // 
            this.xAutoRank.AutoSize = true;
            this.xAutoRank.Location = new System.Drawing.Point(9, 188);
            this.xAutoRank.Name = "xAutoRank";
            this.xAutoRank.Size = new System.Drawing.Size(113, 15);
            this.xAutoRank.TabIndex = 24;
            this.xAutoRank.Text = "Enable AutoRank";
            // 
            // nMaxUndoStates
            // 
            this.nMaxUndoStates.Location = new System.Drawing.Point(115, 71);
            this.nMaxUndoStates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMaxUndoStates.Name = "nMaxUndoStates";
            this.nMaxUndoStates.Size = new System.Drawing.Size(58, 20);
            this.nMaxUndoStates.TabIndex = 23;
            this.nMaxUndoStates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lMaxUndoStates
            // 
            this.lMaxUndoStates.AutoSize = true;
            this.lMaxUndoStates.Location = new System.Drawing.Point(179, 73);
            this.lMaxUndoStates.Name = "lMaxUndoStates";
            this.lMaxUndoStates.Size = new System.Drawing.Size(79, 19);
            this.lMaxUndoStates.TabIndex = 22;
            this.lMaxUndoStates.Text = "states, up to";
            // 
            // lIPWarning
            // 
            this.lIPWarning.AutoSize = true;
            this.lIPWarning.Location = new System.Drawing.Point(112, 131);
            this.lIPWarning.Name = "lIPWarning";
            this.lIPWarning.Size = new System.Drawing.Size(500, 19);
            this.lIPWarning.TabIndex = 20;
            this.lIPWarning.Text = "Note: You do not need to specify an IP address unless you have multiple NICs or I" +
    "Ps.";
            // 
            // tIP
            // 
            // 
            // 
            // 
            this.tIP.CustomButton.Image = null;
            this.tIP.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.tIP.CustomButton.Name = "";
            this.tIP.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tIP.CustomButton.TabIndex = 1;
            this.tIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tIP.CustomButton.UseSelectable = true;
            this.tIP.CustomButton.Visible = false;
            this.tIP.Lines = new string[0];
            this.tIP.Location = new System.Drawing.Point(115, 107);
            this.tIP.MaxLength = 15;
            this.tIP.Name = "tIP";
            this.tIP.PasswordChar = '\0';
            this.tIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tIP.SelectedText = "";
            this.tIP.SelectionLength = 0;
            this.tIP.SelectionStart = 0;
            this.tIP.ShortcutsEnabled = true;
            this.tIP.Size = new System.Drawing.Size(97, 21);
            this.tIP.TabIndex = 19;
            this.tIP.UseSelectable = true;
            this.tIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xIP
            // 
            this.xIP.AutoSize = true;
            this.xIP.Location = new System.Drawing.Point(6, 109);
            this.xIP.Name = "xIP";
            this.xIP.Size = new System.Drawing.Size(95, 15);
            this.xIP.TabIndex = 18;
            this.xIP.Text = "Designated IP";
            // 
            // lConsoleName
            // 
            this.lConsoleName.AutoSize = true;
            this.lConsoleName.Location = new System.Drawing.Point(6, 161);
            this.lConsoleName.Name = "lConsoleName";
            this.lConsoleName.Size = new System.Drawing.Size(93, 19);
            this.lConsoleName.TabIndex = 7;
            this.lConsoleName.Text = "Console name";
            // 
            // tConsoleName
            // 
            // 
            // 
            // 
            this.tConsoleName.CustomButton.Image = null;
            this.tConsoleName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.tConsoleName.CustomButton.Name = "";
            this.tConsoleName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tConsoleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tConsoleName.CustomButton.TabIndex = 1;
            this.tConsoleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tConsoleName.CustomButton.UseSelectable = true;
            this.tConsoleName.CustomButton.Visible = false;
            this.tConsoleName.Lines = new string[0];
            this.tConsoleName.Location = new System.Drawing.Point(115, 158);
            this.tConsoleName.MaxLength = 32767;
            this.tConsoleName.Name = "tConsoleName";
            this.tConsoleName.PasswordChar = '\0';
            this.tConsoleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tConsoleName.SelectedText = "";
            this.tConsoleName.SelectionLength = 0;
            this.tConsoleName.SelectionStart = 0;
            this.tConsoleName.ShortcutsEnabled = true;
            this.tConsoleName.Size = new System.Drawing.Size(167, 21);
            this.tConsoleName.TabIndex = 8;
            this.tConsoleName.UseSelectable = true;
            this.tConsoleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tConsoleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nMaxUndo
            // 
            this.nMaxUndo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxUndo.Location = new System.Drawing.Point(257, 71);
            this.nMaxUndo.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nMaxUndo.Name = "nMaxUndo";
            this.nMaxUndo.Size = new System.Drawing.Size(86, 20);
            this.nMaxUndo.TabIndex = 5;
            this.nMaxUndo.Value = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            // 
            // lMaxUndoUnits
            // 
            this.lMaxUndoUnits.AutoSize = true;
            this.lMaxUndoUnits.Location = new System.Drawing.Point(349, 73);
            this.lMaxUndoUnits.Name = "lMaxUndoUnits";
            this.lMaxUndoUnits.Size = new System.Drawing.Size(282, 19);
            this.lMaxUndoUnits.TabIndex = 6;
            this.lMaxUndoUnits.Text = "blocks each (up to 16.0 MB of RAM per player)";
            // 
            // xMaxUndo
            // 
            this.xMaxUndo.AutoSize = true;
            this.xMaxUndo.Checked = true;
            this.xMaxUndo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xMaxUndo.Location = new System.Drawing.Point(6, 72);
            this.xMaxUndo.Name = "xMaxUndo";
            this.xMaxUndo.Size = new System.Drawing.Size(100, 15);
            this.xMaxUndo.TabIndex = 4;
            this.xMaxUndo.Text = "Limit /undo to";
            // 
            // xRelayAllBlockUpdates
            // 
            this.xRelayAllBlockUpdates.AutoSize = true;
            this.xRelayAllBlockUpdates.Location = new System.Drawing.Point(6, 21);
            this.xRelayAllBlockUpdates.Name = "xRelayAllBlockUpdates";
            this.xRelayAllBlockUpdates.Size = new System.Drawing.Size(543, 15);
            this.xRelayAllBlockUpdates.TabIndex = 1;
            this.xRelayAllBlockUpdates.Text = "When a player changes a block, send him the redundant update packet anyway (origi" +
    "nal behavior).";
            // 
            // xNoPartialPositionUpdates
            // 
            this.xNoPartialPositionUpdates.AutoSize = true;
            this.xNoPartialPositionUpdates.Location = new System.Drawing.Point(6, 46);
            this.xNoPartialPositionUpdates.Name = "xNoPartialPositionUpdates";
            this.xNoPartialPositionUpdates.Size = new System.Drawing.Size(311, 15);
            this.xNoPartialPositionUpdates.TabIndex = 2;
            this.xNoPartialPositionUpdates.Text = "Do not use partial position updates (opcodes 9, 10, 11).";
            // 
            // lAdvancedWarning
            // 
            this.lAdvancedWarning.AutoSize = true;
            this.lAdvancedWarning.Location = new System.Drawing.Point(15, 21);
            this.lAdvancedWarning.Name = "lAdvancedWarning";
            this.lAdvancedWarning.Size = new System.Drawing.Size(510, 38);
            this.lAdvancedWarning.TabIndex = 0;
            this.lAdvancedWarning.Text = "Warning: Altering these settings may decrease your server\'s stability and perform" +
    "ance.\r\nIf you\'re not sure what these settings do, you probably shouldn\'t change " +
    "them...";
            // 
            // xLowLatencyMode
            // 
            this.xLowLatencyMode.AutoSize = true;
            this.xLowLatencyMode.Location = new System.Drawing.Point(6, 64);
            this.xLowLatencyMode.Name = "xLowLatencyMode";
            this.xLowLatencyMode.Size = new System.Drawing.Size(528, 15);
            this.xLowLatencyMode.TabIndex = 3;
            this.xLowLatencyMode.Text = "Low-latency mode (disables Nagle\'s algorithm, reducing latency but increasing ban" +
    "dwidth use).";
            // 
            // lProcessPriority
            // 
            this.lProcessPriority.AutoSize = true;
            this.lProcessPriority.Location = new System.Drawing.Point(19, 94);
            this.lProcessPriority.Name = "lProcessPriority";
            this.lProcessPriority.Size = new System.Drawing.Size(99, 19);
            this.lProcessPriority.TabIndex = 10;
            this.lProcessPriority.Text = "Process priority";
            // 
            // cProcessPriority
            // 
            this.cProcessPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cProcessPriority.ItemHeight = 23;
            this.cProcessPriority.Items.AddRange(new object[] {
            "(system default)",
            "High",
            "Above Normal",
            "Normal",
            "Below Normal",
            "Low"});
            this.cProcessPriority.Location = new System.Drawing.Point(115, 91);
            this.cProcessPriority.Name = "cProcessPriority";
            this.cProcessPriority.Size = new System.Drawing.Size(109, 29);
            this.cProcessPriority.TabIndex = 11;
            this.cProcessPriority.UseSelectable = true;
            // 
            // nTickInterval
            // 
            this.nTickInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nTickInterval.Location = new System.Drawing.Point(429, 92);
            this.nTickInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTickInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nTickInterval.Name = "nTickInterval";
            this.nTickInterval.Size = new System.Drawing.Size(70, 20);
            this.nTickInterval.TabIndex = 13;
            this.nTickInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lTickIntervalUnits
            // 
            this.lTickIntervalUnits.AutoSize = true;
            this.lTickIntervalUnits.Location = new System.Drawing.Point(505, 94);
            this.lTickIntervalUnits.Name = "lTickIntervalUnits";
            this.lTickIntervalUnits.Size = new System.Drawing.Size(26, 19);
            this.lTickIntervalUnits.TabIndex = 14;
            this.lTickIntervalUnits.Text = "ms";
            // 
            // lTickInterval
            // 
            this.lTickInterval.AutoSize = true;
            this.lTickInterval.Location = new System.Drawing.Point(352, 94);
            this.lTickInterval.Name = "lTickInterval";
            this.lTickInterval.Size = new System.Drawing.Size(78, 19);
            this.lTickInterval.TabIndex = 12;
            this.lTickInterval.Text = "Tick interval";
            // 
            // nThrottling
            // 
            this.nThrottling.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nThrottling.Location = new System.Drawing.Point(115, 120);
            this.nThrottling.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nThrottling.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nThrottling.Name = "nThrottling";
            this.nThrottling.Size = new System.Drawing.Size(70, 20);
            this.nThrottling.TabIndex = 16;
            this.nThrottling.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // lThrottling
            // 
            this.lThrottling.AutoSize = true;
            this.lThrottling.Location = new System.Drawing.Point(22, 122);
            this.lThrottling.Name = "lThrottling";
            this.lThrottling.Size = new System.Drawing.Size(97, 19);
            this.lThrottling.TabIndex = 15;
            this.lThrottling.Text = "Block throttling";
            // 
            // lThrottlingUnits
            // 
            this.lThrottlingUnits.AutoSize = true;
            this.lThrottlingUnits.Location = new System.Drawing.Point(191, 122);
            this.lThrottlingUnits.Name = "lThrottlingUnits";
            this.lThrottlingUnits.Size = new System.Drawing.Size(142, 19);
            this.lThrottlingUnits.TabIndex = 17;
            this.lThrottlingUnits.Text = "blocks / second / client";
            // 
            // gPerformance
            // 
            this.gPerformance.ActiveControl = null;
            this.gPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPerformance.Controls.Add(this.lAdvancedWarning);
            this.gPerformance.Controls.Add(this.xLowLatencyMode);
            this.gPerformance.Controls.Add(this.lProcessPriority);
            this.gPerformance.Controls.Add(this.cProcessPriority);
            this.gPerformance.Controls.Add(this.nTickInterval);
            this.gPerformance.Controls.Add(this.lTickIntervalUnits);
            this.gPerformance.Controls.Add(this.lTickInterval);
            this.gPerformance.Controls.Add(this.nThrottling);
            this.gPerformance.Controls.Add(this.lThrottling);
            this.gPerformance.Controls.Add(this.lThrottlingUnits);
            this.gPerformance.Location = new System.Drawing.Point(34, 297);
            this.gPerformance.Name = "gPerformance";
            this.gPerformance.Size = new System.Drawing.Size(654, 165);
            this.gPerformance.TabIndex = 6;
            this.gPerformance.TabStop = false;
            this.gPerformance.Text = "Performance";
            this.gPerformance.UseSelectable = true;
            // 
            // gAdvancedMisc
            // 
            this.gAdvancedMisc.ActiveControl = null;
            this.gAdvancedMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gAdvancedMisc.Controls.Add(this.xAutoRank);
            this.gAdvancedMisc.Controls.Add(this.nMaxUndoStates);
            this.gAdvancedMisc.Controls.Add(this.lMaxUndoStates);
            this.gAdvancedMisc.Controls.Add(this.lIPWarning);
            this.gAdvancedMisc.Controls.Add(this.tIP);
            this.gAdvancedMisc.Controls.Add(this.xIP);
            this.gAdvancedMisc.Controls.Add(this.lConsoleName);
            this.gAdvancedMisc.Controls.Add(this.tConsoleName);
            this.gAdvancedMisc.Controls.Add(this.nMaxUndo);
            this.gAdvancedMisc.Controls.Add(this.lMaxUndoUnits);
            this.gAdvancedMisc.Controls.Add(this.xMaxUndo);
            this.gAdvancedMisc.Controls.Add(this.xRelayAllBlockUpdates);
            this.gAdvancedMisc.Controls.Add(this.xNoPartialPositionUpdates);
            this.gAdvancedMisc.Location = new System.Drawing.Point(34, 78);
            this.gAdvancedMisc.Name = "gAdvancedMisc";
            this.gAdvancedMisc.Size = new System.Drawing.Size(654, 213);
            this.gAdvancedMisc.TabIndex = 5;
            this.gAdvancedMisc.TabStop = false;
            this.gAdvancedMisc.Text = "Miscellaneous";
            this.gAdvancedMisc.UseSelectable = true;
            // 
            // Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 541);
            this.Controls.Add(this.gPerformance);
            this.Controls.Add(this.gAdvancedMisc);
            this.Name = "Advanced";
            this.Text = "Advanced";
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndoStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTickInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nThrottling)).EndInit();
            this.gPerformance.ResumeLayout(false);
            this.gPerformance.PerformLayout();
            this.gAdvancedMisc.ResumeLayout(false);
            this.gAdvancedMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox xAutoRank;
        internal System.Windows.Forms.NumericUpDown nMaxUndoStates;
        internal MetroFramework.Controls.MetroLabel lMaxUndoStates;
        internal MetroFramework.Controls.MetroLabel lIPWarning;
        internal MetroFramework.Controls.MetroTextBox tIP;
        internal System.Windows.Forms.CheckBox xIP;
        internal MetroFramework.Controls.MetroLabel lConsoleName;
        internal MetroFramework.Controls.MetroTextBox tConsoleName;
        internal System.Windows.Forms.NumericUpDown nMaxUndo;
        internal MetroFramework.Controls.MetroLabel lMaxUndoUnits;
        internal System.Windows.Forms.CheckBox xMaxUndo;
        internal System.Windows.Forms.CheckBox xRelayAllBlockUpdates;
        internal System.Windows.Forms.CheckBox xNoPartialPositionUpdates;
        internal MetroFramework.Controls.MetroLabel lAdvancedWarning;
        internal System.Windows.Forms.CheckBox xLowLatencyMode;
        internal MetroFramework.Controls.MetroLabel lProcessPriority;
        internal MetroFramework.Controls.MetroComboBox cProcessPriority;
        internal System.Windows.Forms.NumericUpDown nTickInterval;
        internal MetroFramework.Controls.MetroLabel lTickIntervalUnits;
        internal MetroFramework.Controls.MetroLabel lTickInterval;
        internal System.Windows.Forms.NumericUpDown nThrottling;
        internal MetroFramework.Controls.MetroLabel lThrottling;
        internal MetroFramework.Controls.MetroLabel lThrottlingUnits;
        internal MetroFramework.Controls.MetroTile gPerformance;
        internal MetroFramework.Controls.MetroTile gAdvancedMisc;
    }
}