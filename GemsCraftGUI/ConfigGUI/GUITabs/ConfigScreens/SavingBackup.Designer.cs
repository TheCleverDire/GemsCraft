namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class SavingBackup
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
            this.groupBox5 = new MetroFramework.Controls.MetroTile();
            this.bUpdate = new MetroFramework.Controls.MetroButton();
            this.checkUpdate = new MetroFramework.Controls.MetroCheckBox();
            this.gDataBackup = new MetroFramework.Controls.MetroTile();
            this.xBackupDataOnStartup = new MetroFramework.Controls.MetroCheckBox();
            this.gSaving = new MetroFramework.Controls.MetroTile();
            this.nSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.lSaveIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.xSaveInterval = new MetroFramework.Controls.MetroCheckBox();
            this.gBackups = new MetroFramework.Controls.MetroTile();
            this.xBackupOnlyWhenChanged = new MetroFramework.Controls.MetroCheckBox();
            this.lMaxBackupSize = new MetroFramework.Controls.MetroLabel();
            this.xMaxBackupSize = new MetroFramework.Controls.MetroCheckBox();
            this.nMaxBackupSize = new System.Windows.Forms.NumericUpDown();
            this.xMaxBackups = new MetroFramework.Controls.MetroCheckBox();
            this.xBackupOnStartup = new MetroFramework.Controls.MetroCheckBox();
            this.lMaxBackups = new MetroFramework.Controls.MetroLabel();
            this.nMaxBackups = new System.Windows.Forms.NumericUpDown();
            this.nBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.lBackupIntervalUnits = new MetroFramework.Controls.MetroLabel();
            this.xBackupInterval = new MetroFramework.Controls.MetroCheckBox();
            this.xBackupOnJoin = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5.SuspendLayout();
            this.gDataBackup.SuspendLayout();
            this.gSaving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSaveInterval)).BeginInit();
            this.gBackups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackupInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.ActiveControl = null;
            this.groupBox5.Controls.Add(this.bUpdate);
            this.groupBox5.Controls.Add(this.checkUpdate);
            this.groupBox5.Location = new System.Drawing.Point(23, 343);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(635, 54);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update";
            this.groupBox5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.groupBox5.UseSelectable = true;
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bUpdate.Location = new System.Drawing.Point(221, 14);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(205, 28);
            this.bUpdate.TabIndex = 23;
            this.bUpdate.Text = "Manual Update Check";
            this.bUpdate.UseSelectable = true;
            // 
            // checkUpdate
            // 
            this.checkUpdate.AutoSize = true;
            this.checkUpdate.Location = new System.Drawing.Point(11, 20);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(197, 15);
            this.checkUpdate.TabIndex = 22;
            this.checkUpdate.Text = "Automatically Check for Updates";
            this.checkUpdate.UseSelectable = true;
            // 
            // gDataBackup
            // 
            this.gDataBackup.ActiveControl = null;
            this.gDataBackup.Controls.Add(this.xBackupDataOnStartup);
            this.gDataBackup.Location = new System.Drawing.Point(23, 285);
            this.gDataBackup.Name = "gDataBackup";
            this.gDataBackup.Size = new System.Drawing.Size(636, 52);
            this.gDataBackup.TabIndex = 6;
            this.gDataBackup.TabStop = false;
            this.gDataBackup.Text = "Data Backup";
            this.gDataBackup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gDataBackup.UseSelectable = true;
            // 
            // xBackupDataOnStartup
            // 
            this.xBackupDataOnStartup.AutoSize = true;
            this.xBackupDataOnStartup.Location = new System.Drawing.Point(16, 20);
            this.xBackupDataOnStartup.Name = "xBackupDataOnStartup";
            this.xBackupDataOnStartup.Size = new System.Drawing.Size(249, 15);
            this.xBackupDataOnStartup.TabIndex = 0;
            this.xBackupDataOnStartup.Text = "Backup PlayerDB and IP ban list on startup.";
            this.xBackupDataOnStartup.UseSelectable = true;
            // 
            // gSaving
            // 
            this.gSaving.ActiveControl = null;
            this.gSaving.Controls.Add(this.nSaveInterval);
            this.gSaving.Controls.Add(this.lSaveIntervalUnits);
            this.gSaving.Controls.Add(this.xSaveInterval);
            this.gSaving.Location = new System.Drawing.Point(23, 63);
            this.gSaving.Name = "gSaving";
            this.gSaving.Size = new System.Drawing.Size(636, 52);
            this.gSaving.TabIndex = 4;
            this.gSaving.TabStop = false;
            this.gSaving.Text = "Map Saving";
            this.gSaving.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gSaving.UseSelectable = true;
            // 
            // nSaveInterval
            // 
            this.nSaveInterval.Location = new System.Drawing.Point(136, 20);
            this.nSaveInterval.Name = "nSaveInterval";
            this.nSaveInterval.Size = new System.Drawing.Size(48, 20);
            this.nSaveInterval.TabIndex = 1;
            // 
            // lSaveIntervalUnits
            // 
            this.lSaveIntervalUnits.AutoSize = true;
            this.lSaveIntervalUnits.Location = new System.Drawing.Point(190, 22);
            this.lSaveIntervalUnits.Name = "lSaveIntervalUnits";
            this.lSaveIntervalUnits.Size = new System.Drawing.Size(55, 19);
            this.lSaveIntervalUnits.TabIndex = 2;
            this.lSaveIntervalUnits.Text = "seconds";
            // 
            // xSaveInterval
            // 
            this.xSaveInterval.AutoSize = true;
            this.xSaveInterval.Location = new System.Drawing.Point(12, 21);
            this.xSaveInterval.Name = "xSaveInterval";
            this.xSaveInterval.Size = new System.Drawing.Size(110, 15);
            this.xSaveInterval.TabIndex = 0;
            this.xSaveInterval.Text = "Save maps every";
            this.xSaveInterval.UseSelectable = true;
            // 
            // gBackups
            // 
            this.gBackups.ActiveControl = null;
            this.gBackups.Controls.Add(this.xBackupOnlyWhenChanged);
            this.gBackups.Controls.Add(this.lMaxBackupSize);
            this.gBackups.Controls.Add(this.xMaxBackupSize);
            this.gBackups.Controls.Add(this.nMaxBackupSize);
            this.gBackups.Controls.Add(this.xMaxBackups);
            this.gBackups.Controls.Add(this.xBackupOnStartup);
            this.gBackups.Controls.Add(this.lMaxBackups);
            this.gBackups.Controls.Add(this.nMaxBackups);
            this.gBackups.Controls.Add(this.nBackupInterval);
            this.gBackups.Controls.Add(this.lBackupIntervalUnits);
            this.gBackups.Controls.Add(this.xBackupInterval);
            this.gBackups.Controls.Add(this.xBackupOnJoin);
            this.gBackups.Location = new System.Drawing.Point(23, 121);
            this.gBackups.Name = "gBackups";
            this.gBackups.Size = new System.Drawing.Size(636, 158);
            this.gBackups.TabIndex = 5;
            this.gBackups.TabStop = false;
            this.gBackups.Text = "Map Backups";
            this.gBackups.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gBackups.UseSelectable = true;
            // 
            // xBackupOnlyWhenChanged
            // 
            this.xBackupOnlyWhenChanged.AutoSize = true;
            this.xBackupOnlyWhenChanged.Location = new System.Drawing.Point(369, 46);
            this.xBackupOnlyWhenChanged.Name = "xBackupOnlyWhenChanged";
            this.xBackupOnlyWhenChanged.Size = new System.Drawing.Size(250, 15);
            this.xBackupOnlyWhenChanged.TabIndex = 4;
            this.xBackupOnlyWhenChanged.Text = "Skip timed backups if map hasn\'t changed.";
            this.xBackupOnlyWhenChanged.UseSelectable = true;
            // 
            // lMaxBackupSize
            // 
            this.lMaxBackupSize.AutoSize = true;
            this.lMaxBackupSize.Location = new System.Drawing.Point(418, 124);
            this.lMaxBackupSize.Name = "lMaxBackupSize";
            this.lMaxBackupSize.Size = new System.Drawing.Size(111, 19);
            this.lMaxBackupSize.TabIndex = 11;
            this.lMaxBackupSize.Text = "MB of disk space.";
            // 
            // xMaxBackupSize
            // 
            this.xMaxBackupSize.AutoSize = true;
            this.xMaxBackupSize.Location = new System.Drawing.Point(16, 123);
            this.xMaxBackupSize.Name = "xMaxBackupSize";
            this.xMaxBackupSize.Size = new System.Drawing.Size(308, 15);
            this.xMaxBackupSize.TabIndex = 9;
            this.xMaxBackupSize.Text = "Delete old backups if the directory takes up more than";
            this.xMaxBackupSize.UseSelectable = true;
            // 
            // nMaxBackupSize
            // 
            this.nMaxBackupSize.Location = new System.Drawing.Point(339, 122);
            this.nMaxBackupSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nMaxBackupSize.Name = "nMaxBackupSize";
            this.nMaxBackupSize.Size = new System.Drawing.Size(73, 20);
            this.nMaxBackupSize.TabIndex = 10;
            // 
            // xMaxBackups
            // 
            this.xMaxBackups.AutoSize = true;
            this.xMaxBackups.Location = new System.Drawing.Point(16, 98);
            this.xMaxBackups.Name = "xMaxBackups";
            this.xMaxBackups.Size = new System.Drawing.Size(240, 15);
            this.xMaxBackups.TabIndex = 6;
            this.xMaxBackups.Text = "Delete old backups if there are more than";
            this.xMaxBackups.UseSelectable = true;
            // 
            // xBackupOnStartup
            // 
            this.xBackupOnStartup.AutoSize = true;
            this.xBackupOnStartup.Enabled = false;
            this.xBackupOnStartup.Location = new System.Drawing.Point(16, 20);
            this.xBackupOnStartup.Name = "xBackupOnStartup";
            this.xBackupOnStartup.Size = new System.Drawing.Size(161, 15);
            this.xBackupOnStartup.TabIndex = 0;
            this.xBackupOnStartup.Text = "Create backups on startup";
            this.xBackupOnStartup.UseSelectable = true;
            // 
            // lMaxBackups
            // 
            this.lMaxBackups.AutoSize = true;
            this.lMaxBackups.Location = new System.Drawing.Point(336, 99);
            this.lMaxBackups.Name = "lMaxBackups";
            this.lMaxBackups.Size = new System.Drawing.Size(172, 19);
            this.lMaxBackups.TabIndex = 8;
            this.lMaxBackups.Text = "files in the backup directory.";
            // 
            // nMaxBackups
            // 
            this.nMaxBackups.Location = new System.Drawing.Point(273, 97);
            this.nMaxBackups.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nMaxBackups.Name = "nMaxBackups";
            this.nMaxBackups.Size = new System.Drawing.Size(57, 20);
            this.nMaxBackups.TabIndex = 7;
            // 
            // nBackupInterval
            // 
            this.nBackupInterval.Location = new System.Drawing.Point(164, 45);
            this.nBackupInterval.Name = "nBackupInterval";
            this.nBackupInterval.Size = new System.Drawing.Size(48, 20);
            this.nBackupInterval.TabIndex = 2;
            // 
            // lBackupIntervalUnits
            // 
            this.lBackupIntervalUnits.AutoSize = true;
            this.lBackupIntervalUnits.Location = new System.Drawing.Point(218, 47);
            this.lBackupIntervalUnits.Name = "lBackupIntervalUnits";
            this.lBackupIntervalUnits.Size = new System.Drawing.Size(54, 19);
            this.lBackupIntervalUnits.TabIndex = 3;
            this.lBackupIntervalUnits.Text = "minutes";
            // 
            // xBackupInterval
            // 
            this.xBackupInterval.AutoSize = true;
            this.xBackupInterval.Location = new System.Drawing.Point(16, 46);
            this.xBackupInterval.Name = "xBackupInterval";
            this.xBackupInterval.Size = new System.Drawing.Size(135, 15);
            this.xBackupInterval.TabIndex = 1;
            this.xBackupInterval.Text = "Create backups every";
            this.xBackupInterval.UseSelectable = true;
            // 
            // xBackupOnJoin
            // 
            this.xBackupOnJoin.AutoSize = true;
            this.xBackupOnJoin.Location = new System.Drawing.Point(16, 72);
            this.xBackupOnJoin.Name = "xBackupOnJoin";
            this.xBackupOnJoin.Size = new System.Drawing.Size(267, 15);
            this.xBackupOnJoin.TabIndex = 5;
            this.xBackupOnJoin.Text = "Create backup whenever a player joins a world";
            this.xBackupOnJoin.UseSelectable = true;
            // 
            // SavingBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 415);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gDataBackup);
            this.Controls.Add(this.gSaving);
            this.Controls.Add(this.gBackups);
            this.Name = "SavingBackup";
            this.Text = "SavingBackup";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gDataBackup.ResumeLayout(false);
            this.gDataBackup.PerformLayout();
            this.gSaving.ResumeLayout(false);
            this.gSaving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSaveInterval)).EndInit();
            this.gBackups.ResumeLayout(false);
            this.gBackups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxBackups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBackupInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile groupBox5;
        internal MetroFramework.Controls.MetroButton bUpdate;
        internal MetroFramework.Controls.MetroCheckBox checkUpdate;
        internal MetroFramework.Controls.MetroTile gDataBackup;
        internal MetroFramework.Controls.MetroCheckBox xBackupDataOnStartup;
        internal MetroFramework.Controls.MetroTile gSaving;
        internal System.Windows.Forms.NumericUpDown nSaveInterval;
        internal MetroFramework.Controls.MetroLabel lSaveIntervalUnits;
        internal MetroFramework.Controls.MetroCheckBox xSaveInterval;
        internal MetroFramework.Controls.MetroTile gBackups;
        internal MetroFramework.Controls.MetroCheckBox xBackupOnlyWhenChanged;
        internal MetroFramework.Controls.MetroLabel lMaxBackupSize;
        internal MetroFramework.Controls.MetroCheckBox xMaxBackupSize;
        internal System.Windows.Forms.NumericUpDown nMaxBackupSize;
        internal MetroFramework.Controls.MetroCheckBox xMaxBackups;
        internal MetroFramework.Controls.MetroCheckBox xBackupOnStartup;
        internal MetroFramework.Controls.MetroLabel lMaxBackups;
        internal System.Windows.Forms.NumericUpDown nMaxBackups;
        internal System.Windows.Forms.NumericUpDown nBackupInterval;
        internal MetroFramework.Controls.MetroLabel lBackupIntervalUnits;
        internal MetroFramework.Controls.MetroCheckBox xBackupInterval;
        internal MetroFramework.Controls.MetroCheckBox xBackupOnJoin;
    }
}