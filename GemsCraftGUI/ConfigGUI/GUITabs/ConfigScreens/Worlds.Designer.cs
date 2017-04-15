namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Worlds
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mcbPrison = new MetroFramework.Controls.MetroCheckBox();
            this.cboPrison = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.xWoMEnableEnvExtensions = new MetroFramework.Controls.MetroCheckBox();
            this.bMapPath = new MetroFramework.Controls.MetroButton();
            this.xMapPath = new MetroFramework.Controls.MetroCheckBox();
            this.tMapPath = new MetroFramework.Controls.MetroTextBox();
            this.lDefaultBuildRank = new MetroFramework.Controls.MetroLabel();
            this.cDefaultBuildRank = new MetroFramework.Controls.MetroComboBox();
            this.cMainWorld = new MetroFramework.Controls.MetroComboBox();
            this.lMainWorld = new MetroFramework.Controls.MetroLabel();
            this.bWorldEdit = new MetroFramework.Controls.MetroButton();
            this.bAddWorld = new MetroFramework.Controls.MetroButton();
            this.bWorldDelete = new MetroFramework.Controls.MetroButton();
            this.dgvWorlds = new System.Windows.Forms.DataGridView();
            this.dgvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcBuild = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcBackup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcHidden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvcBlockDB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorlds)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbPrison
            // 
            this.mcbPrison.AutoSize = true;
            this.mcbPrison.Location = new System.Drawing.Point(354, 83);
            this.mcbPrison.Name = "mcbPrison";
            this.mcbPrison.Size = new System.Drawing.Size(101, 15);
            this.mcbPrison.TabIndex = 40;
            this.mcbPrison.Text = "Prison Enabled";
            this.mcbPrison.UseSelectable = true;
            // 
            // cboPrison
            // 
            this.cboPrison.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPrison.ItemHeight = 23;
            this.cboPrison.Location = new System.Drawing.Point(557, 73);
            this.cboPrison.Name = "cboPrison";
            this.cboPrison.Size = new System.Drawing.Size(102, 29);
            this.cboPrison.TabIndex = 39;
            this.cboPrison.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Prison World:";
            // 
            // xWoMEnableEnvExtensions
            // 
            this.xWoMEnableEnvExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xWoMEnableEnvExtensions.AutoSize = true;
            this.xWoMEnableEnvExtensions.Location = new System.Drawing.Point(23, 481);
            this.xWoMEnableEnvExtensions.Name = "xWoMEnableEnvExtensions";
            this.xWoMEnableEnvExtensions.Size = new System.Drawing.Size(239, 15);
            this.xWoMEnableEnvExtensions.TabIndex = 37;
            this.xWoMEnableEnvExtensions.Text = "Enable Env Extensions (/MapEdit or /Env)";
            this.xWoMEnableEnvExtensions.UseSelectable = true;
            // 
            // bMapPath
            // 
            this.bMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMapPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bMapPath.Enabled = false;
            this.bMapPath.Location = new System.Drawing.Point(602, 450);
            this.bMapPath.Name = "bMapPath";
            this.bMapPath.Size = new System.Drawing.Size(62, 23);
            this.bMapPath.TabIndex = 36;
            this.bMapPath.Text = "Browse";
            this.bMapPath.UseSelectable = true;
            // 
            // xMapPath
            // 
            this.xMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xMapPath.AutoSize = true;
            this.xMapPath.Location = new System.Drawing.Point(23, 454);
            this.xMapPath.Name = "xMapPath";
            this.xMapPath.Size = new System.Drawing.Size(185, 15);
            this.xMapPath.TabIndex = 34;
            this.xMapPath.Text = "Custom path for storing maps:";
            this.xMapPath.UseSelectable = true;
            // 
            // tMapPath
            // 
            this.tMapPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tMapPath.CustomButton.Image = null;
            this.tMapPath.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.tMapPath.CustomButton.Name = "";
            this.tMapPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tMapPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tMapPath.CustomButton.TabIndex = 1;
            this.tMapPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tMapPath.CustomButton.UseSelectable = true;
            this.tMapPath.CustomButton.Visible = false;
            this.tMapPath.Enabled = false;
            this.tMapPath.Lines = new string[0];
            this.tMapPath.Location = new System.Drawing.Point(218, 452);
            this.tMapPath.MaxLength = 32767;
            this.tMapPath.Name = "tMapPath";
            this.tMapPath.PasswordChar = '\0';
            this.tMapPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tMapPath.SelectedText = "";
            this.tMapPath.SelectionLength = 0;
            this.tMapPath.SelectionStart = 0;
            this.tMapPath.ShortcutsEnabled = true;
            this.tMapPath.Size = new System.Drawing.Size(378, 19);
            this.tMapPath.TabIndex = 35;
            this.tMapPath.UseSelectable = true;
            this.tMapPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tMapPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lDefaultBuildRank
            // 
            this.lDefaultBuildRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDefaultBuildRank.AutoSize = true;
            this.lDefaultBuildRank.Location = new System.Drawing.Point(11, 419);
            this.lDefaultBuildRank.Name = "lDefaultBuildRank";
            this.lDefaultBuildRank.Size = new System.Drawing.Size(374, 19);
            this.lDefaultBuildRank.TabIndex = 32;
            this.lDefaultBuildRank.Text = "Default rank requirement for building on newly-loaded worlds:";
            // 
            // cDefaultBuildRank
            // 
            this.cDefaultBuildRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cDefaultBuildRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cDefaultBuildRank.FormattingEnabled = true;
            this.cDefaultBuildRank.ItemHeight = 23;
            this.cDefaultBuildRank.Location = new System.Drawing.Point(387, 419);
            this.cDefaultBuildRank.Name = "cDefaultBuildRank";
            this.cDefaultBuildRank.Size = new System.Drawing.Size(121, 29);
            this.cDefaultBuildRank.TabIndex = 33;
            this.cDefaultBuildRank.UseSelectable = true;
            // 
            // cMainWorld
            // 
            this.cMainWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cMainWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMainWorld.ItemHeight = 23;
            this.cMainWorld.Location = new System.Drawing.Point(557, 44);
            this.cMainWorld.Name = "cMainWorld";
            this.cMainWorld.Size = new System.Drawing.Size(102, 29);
            this.cMainWorld.TabIndex = 31;
            this.cMainWorld.UseSelectable = true;
            // 
            // lMainWorld
            // 
            this.lMainWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lMainWorld.AutoSize = true;
            this.lMainWorld.Location = new System.Drawing.Point(473, 54);
            this.lMainWorld.Name = "lMainWorld";
            this.lMainWorld.Size = new System.Drawing.Size(78, 19);
            this.lMainWorld.TabIndex = 30;
            this.lMainWorld.Text = "Main world:";
            // 
            // bWorldEdit
            // 
            this.bWorldEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWorldEdit.Enabled = false;
            this.bWorldEdit.Location = new System.Drawing.Point(129, 63);
            this.bWorldEdit.Name = "bWorldEdit";
            this.bWorldEdit.Size = new System.Drawing.Size(100, 28);
            this.bWorldEdit.TabIndex = 28;
            this.bWorldEdit.Text = "Edit";
            this.bWorldEdit.UseSelectable = true;
            // 
            // bAddWorld
            // 
            this.bAddWorld.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAddWorld.Location = new System.Drawing.Point(23, 63);
            this.bAddWorld.Name = "bAddWorld";
            this.bAddWorld.Size = new System.Drawing.Size(100, 28);
            this.bAddWorld.TabIndex = 27;
            this.bAddWorld.Text = "Add World";
            this.bAddWorld.UseSelectable = true;
            // 
            // bWorldDelete
            // 
            this.bWorldDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bWorldDelete.Enabled = false;
            this.bWorldDelete.Location = new System.Drawing.Point(235, 63);
            this.bWorldDelete.Name = "bWorldDelete";
            this.bWorldDelete.Size = new System.Drawing.Size(100, 28);
            this.bWorldDelete.TabIndex = 29;
            this.bWorldDelete.Text = "Delete World";
            this.bWorldDelete.UseSelectable = true;
            // 
            // dgvWorlds
            // 
            this.dgvWorlds.AllowUserToAddRows = false;
            this.dgvWorlds.AllowUserToDeleteRows = false;
            this.dgvWorlds.AllowUserToOrderColumns = true;
            this.dgvWorlds.AllowUserToResizeRows = false;
            this.dgvWorlds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorlds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorlds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcName,
            this.dgvcDescription,
            this.dgvcAccess,
            this.dgvcBuild,
            this.dgvcBackup,
            this.dgvcHidden,
            this.dgvcBlockDB});
            this.dgvWorlds.Location = new System.Drawing.Point(23, 102);
            this.dgvWorlds.MultiSelect = false;
            this.dgvWorlds.Name = "dgvWorlds";
            this.dgvWorlds.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dgvWorlds.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorlds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorlds.Size = new System.Drawing.Size(636, 311);
            this.dgvWorlds.TabIndex = 26;
            // 
            // dgvcName
            // 
            this.dgvcName.DataPropertyName = "Name";
            this.dgvcName.HeaderText = "World Name";
            this.dgvcName.Name = "dgvcName";
            this.dgvcName.Width = 110;
            // 
            // dgvcDescription
            // 
            this.dgvcDescription.DataPropertyName = "Description";
            this.dgvcDescription.HeaderText = "";
            this.dgvcDescription.Name = "dgvcDescription";
            this.dgvcDescription.ReadOnly = true;
            this.dgvcDescription.Width = 130;
            // 
            // dgvcAccess
            // 
            this.dgvcAccess.DataPropertyName = "AccessPermission";
            this.dgvcAccess.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcAccess.HeaderText = "Access";
            this.dgvcAccess.Name = "dgvcAccess";
            this.dgvcAccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcBuild
            // 
            this.dgvcBuild.DataPropertyName = "BuildPermission";
            this.dgvcBuild.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcBuild.HeaderText = "Build";
            this.dgvcBuild.Name = "dgvcBuild";
            this.dgvcBuild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcBackup
            // 
            this.dgvcBackup.DataPropertyName = "Backup";
            this.dgvcBackup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcBackup.HeaderText = "Backup";
            this.dgvcBackup.Name = "dgvcBackup";
            this.dgvcBackup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcBackup.Width = 90;
            // 
            // dgvcHidden
            // 
            this.dgvcHidden.DataPropertyName = "Hidden";
            this.dgvcHidden.HeaderText = "Hide";
            this.dgvcHidden.Name = "dgvcHidden";
            this.dgvcHidden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcHidden.Width = 40;
            // 
            // dgvcBlockDB
            // 
            this.dgvcBlockDB.DataPropertyName = "BlockDBEnabled";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvcBlockDB.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcBlockDB.HeaderText = "BlockDB";
            this.dgvcBlockDB.Name = "dgvcBlockDB";
            this.dgvcBlockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcBlockDB.ThreeState = true;
            this.dgvcBlockDB.Width = 60;
            // 
            // Worlds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 534);
            this.Controls.Add(this.mcbPrison);
            this.Controls.Add(this.cboPrison);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.xWoMEnableEnvExtensions);
            this.Controls.Add(this.bMapPath);
            this.Controls.Add(this.xMapPath);
            this.Controls.Add(this.tMapPath);
            this.Controls.Add(this.lDefaultBuildRank);
            this.Controls.Add(this.cDefaultBuildRank);
            this.Controls.Add(this.cMainWorld);
            this.Controls.Add(this.lMainWorld);
            this.Controls.Add(this.bWorldEdit);
            this.Controls.Add(this.bAddWorld);
            this.Controls.Add(this.bWorldDelete);
            this.Controls.Add(this.dgvWorlds);
            this.Name = "Worlds";
            this.Text = "Worlds";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorlds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroCheckBox mcbPrison;
        internal MetroFramework.Controls.MetroComboBox cboPrison;
        internal MetroFramework.Controls.MetroLabel label6;
        internal MetroFramework.Controls.MetroCheckBox xWoMEnableEnvExtensions;
        internal MetroFramework.Controls.MetroButton bMapPath;
        internal MetroFramework.Controls.MetroCheckBox xMapPath;
        internal MetroFramework.Controls.MetroTextBox tMapPath;
        internal MetroFramework.Controls.MetroLabel lDefaultBuildRank;
        internal MetroFramework.Controls.MetroComboBox cDefaultBuildRank;
        internal MetroFramework.Controls.MetroComboBox cMainWorld;
        internal MetroFramework.Controls.MetroLabel lMainWorld;
        internal MetroFramework.Controls.MetroButton bWorldEdit;
        internal MetroFramework.Controls.MetroButton bAddWorld;
        internal MetroFramework.Controls.MetroButton bWorldDelete;
        internal System.Windows.Forms.DataGridView dgvWorlds;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgvcName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn dgvcDescription;
        internal System.Windows.Forms.DataGridViewComboBoxColumn dgvcAccess;
        internal System.Windows.Forms.DataGridViewComboBoxColumn dgvcBuild;
        internal System.Windows.Forms.DataGridViewComboBoxColumn dgvcBackup;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn dgvcHidden;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn dgvcBlockDB;
    }
}