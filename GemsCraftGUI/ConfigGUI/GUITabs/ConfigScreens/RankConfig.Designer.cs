using System.Windows.Forms;
using MetroFramework.Controls;
namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class RankConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankConfig));
            this.nKickIdle = new System.Windows.Forms.NumericUpDown();
            this.xAntiGrief = new MetroFramework.Controls.MetroCheckBox();
            this.lAntiGrief2 = new MetroFramework.Controls.MetroLabel();
            this.xKickIdle = new MetroFramework.Controls.MetroCheckBox();
            this.nAntiGriefBlocks = new System.Windows.Forms.NumericUpDown();
            this.xReserveSlot = new MetroFramework.Controls.MetroCheckBox();
            this.permissionLimitBoxContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.bDeleteRank = new MetroFramework.Controls.MetroButton();
            this.gPermissionLimits = new MetroFramework.Controls.MetroTile();
            this.bLowerRank = new MetroFramework.Controls.MetroButton();
            this.tPrefix = new MetroFramework.Controls.MetroTextBox();
            this.vPermissions = new MetroFramework.Controls.MetroListView();
            this.chPermissions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lPrefix = new MetroFramework.Controls.MetroLabel();
            this.lPermissions = new MetroFramework.Controls.MetroLabel();
            this.bAddRank = new MetroFramework.Controls.MetroButton();
            this.lRankColor = new MetroFramework.Controls.MetroLabel();
            this.vRanks = new System.Windows.Forms.ListBox();
            this.tRankName = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lRankList = new MetroFramework.Controls.MetroLabel();
            this.gRankOptions = new MetroFramework.Controls.MetroTile();
            this.lFillLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.nFillLimit = new System.Windows.Forms.NumericUpDown();
            this.lFillLimit = new MetroFramework.Controls.MetroLabel();
            this.nCopyPasteSlots = new System.Windows.Forms.NumericUpDown();
            this.lCopyPasteSlots = new MetroFramework.Controls.MetroLabel();
            this.xAllowSecurityCircumvention = new MetroFramework.Controls.MetroCheckBox();
            this.lAntiGrief1 = new MetroFramework.Controls.MetroLabel();
            this.lAntiGrief3 = new MetroFramework.Controls.MetroLabel();
            this.nAntiGriefSeconds = new System.Windows.Forms.NumericUpDown();
            this.bColorRank = new MetroFramework.Controls.MetroButton();
            this.xDrawLimit = new MetroFramework.Controls.MetroCheckBox();
            this.lDrawLimitUnits = new MetroFramework.Controls.MetroLabel();
            this.lKickIdleUnits = new MetroFramework.Controls.MetroLabel();
            this.nDrawLimit = new System.Windows.Forms.NumericUpDown();
            this.lRankName = new MetroFramework.Controls.MetroLabel();
            this.bRaiseRank = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).BeginInit();
            this.gPermissionLimits.SuspendLayout();
            this.gRankOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFillLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCopyPasteSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // nKickIdle
            // 
            this.nKickIdle.Location = new System.Drawing.Point(116, 77);
            this.nKickIdle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nKickIdle.Name = "nKickIdle";
            this.nKickIdle.Size = new System.Drawing.Size(59, 20);
            this.nKickIdle.TabIndex = 8;
            // 
            // xAntiGrief
            // 
            this.xAntiGrief.AutoSize = true;
            this.xAntiGrief.Location = new System.Drawing.Point(12, 108);
            this.xAntiGrief.Name = "xAntiGrief";
            this.xAntiGrief.Size = new System.Drawing.Size(207, 15);
            this.xAntiGrief.TabIndex = 10;
            this.xAntiGrief.Text = "Enable grief / autoclicker detection";
            this.xAntiGrief.UseSelectable = true;
            // 
            // lAntiGrief2
            // 
            this.lAntiGrief2.AutoSize = true;
            this.lAntiGrief2.Location = new System.Drawing.Point(168, 135);
            this.lAntiGrief2.Name = "lAntiGrief2";
            this.lAntiGrief2.Size = new System.Drawing.Size(59, 19);
            this.lAntiGrief2.TabIndex = 13;
            this.lAntiGrief2.Text = "blocks in";
            // 
            // xKickIdle
            // 
            this.xKickIdle.AutoSize = true;
            this.xKickIdle.Location = new System.Drawing.Point(12, 78);
            this.xKickIdle.Name = "xKickIdle";
            this.xKickIdle.Size = new System.Drawing.Size(95, 15);
            this.xKickIdle.TabIndex = 7;
            this.xKickIdle.Text = "Kick if idle for";
            this.xKickIdle.UseSelectable = true;
            // 
            // nAntiGriefBlocks
            // 
            this.nAntiGriefBlocks.Location = new System.Drawing.Point(103, 133);
            this.nAntiGriefBlocks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nAntiGriefBlocks.Name = "nAntiGriefBlocks";
            this.nAntiGriefBlocks.Size = new System.Drawing.Size(59, 20);
            this.nAntiGriefBlocks.TabIndex = 12;
            // 
            // xReserveSlot
            // 
            this.xReserveSlot.AutoSize = true;
            this.xReserveSlot.Location = new System.Drawing.Point(12, 51);
            this.xReserveSlot.Name = "xReserveSlot";
            this.xReserveSlot.Size = new System.Drawing.Size(120, 15);
            this.xReserveSlot.TabIndex = 4;
            this.xReserveSlot.Text = "Reserve player slot";
            this.xReserveSlot.UseSelectable = true;
            // 
            // permissionLimitBoxContainer
            // 
            this.permissionLimitBoxContainer.AutoScroll = true;
            this.permissionLimitBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionLimitBoxContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.permissionLimitBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.permissionLimitBoxContainer.Margin = new System.Windows.Forms.Padding(0);
            this.permissionLimitBoxContainer.Name = "permissionLimitBoxContainer";
            this.permissionLimitBoxContainer.Size = new System.Drawing.Size(307, 190);
            this.permissionLimitBoxContainer.TabIndex = 0;
            this.permissionLimitBoxContainer.WrapContents = false;
            // 
            // bDeleteRank
            // 
            this.bDeleteRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bDeleteRank.Location = new System.Drawing.Point(99, 78);
            this.bDeleteRank.Name = "bDeleteRank";
            this.bDeleteRank.Size = new System.Drawing.Size(70, 23);
            this.bDeleteRank.TabIndex = 36;
            this.bDeleteRank.Text = "Delete";
            this.bDeleteRank.UseSelectable = true;
            // 
            // gPermissionLimits
            // 
            this.gPermissionLimits.ActiveControl = null;
            this.gPermissionLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPermissionLimits.Controls.Add(this.permissionLimitBoxContainer);
            this.gPermissionLimits.Location = new System.Drawing.Point(175, 331);
            this.gPermissionLimits.Name = "gPermissionLimits";
            this.gPermissionLimits.Size = new System.Drawing.Size(307, 190);
            this.gPermissionLimits.TabIndex = 40;
            this.gPermissionLimits.TabStop = false;
            this.gPermissionLimits.Text = "Permission Limits";
            this.gPermissionLimits.UseSelectable = true;
            // 
            // bLowerRank
            // 
            this.bLowerRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLowerRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bLowerRank.Location = new System.Drawing.Point(99, 470);
            this.bLowerRank.Name = "bLowerRank";
            this.bLowerRank.Size = new System.Drawing.Size(70, 23);
            this.bLowerRank.TabIndex = 38;
            this.bLowerRank.Text = "▼ Lower";
            this.bLowerRank.UseSelectable = true;
            // 
            // tPrefix
            // 
            // 
            // 
            // 
            this.tPrefix.CustomButton.Image = null;
            this.tPrefix.CustomButton.Location = new System.Drawing.Point(2, 1);
            this.tPrefix.CustomButton.Name = "";
            this.tPrefix.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tPrefix.CustomButton.TabIndex = 1;
            this.tPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tPrefix.CustomButton.UseSelectable = true;
            this.tPrefix.CustomButton.Visible = false;
            this.tPrefix.Enabled = false;
            this.tPrefix.Lines = new string[0];
            this.tPrefix.Location = new System.Drawing.Point(279, 20);
            this.tPrefix.MaxLength = 1;
            this.tPrefix.Name = "tPrefix";
            this.tPrefix.PasswordChar = '\0';
            this.tPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tPrefix.SelectedText = "";
            this.tPrefix.SelectionLength = 0;
            this.tPrefix.SelectionStart = 0;
            this.tPrefix.ShortcutsEnabled = true;
            this.tPrefix.Size = new System.Drawing.Size(22, 21);
            this.tPrefix.TabIndex = 3;
            this.tPrefix.UseSelectable = true;
            this.tPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vPermissions
            // 
            this.vPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vPermissions.CheckBoxes = true;
            this.vPermissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPermissions});
            this.vPermissions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.vPermissions.FullRowSelect = true;
            this.vPermissions.GridLines = true;
            this.vPermissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vPermissions.Location = new System.Drawing.Point(488, 82);
            this.vPermissions.MultiSelect = false;
            this.vPermissions.Name = "vPermissions";
            this.vPermissions.OwnerDraw = true;
            this.vPermissions.ShowGroups = false;
            this.vPermissions.ShowItemToolTips = true;
            this.vPermissions.Size = new System.Drawing.Size(171, 315);
            this.vPermissions.TabIndex = 42;
            this.vPermissions.UseCompatibleStateImageBehavior = false;
            this.vPermissions.UseSelectable = true;
            this.vPermissions.View = System.Windows.Forms.View.Details;
            // 
            // chPermissions
            // 
            this.chPermissions.Width = 150;
            // 
            // lPrefix
            // 
            this.lPrefix.AutoSize = true;
            this.lPrefix.Enabled = false;
            this.lPrefix.Location = new System.Drawing.Point(235, 23);
            this.lPrefix.Name = "lPrefix";
            this.lPrefix.Size = new System.Drawing.Size(42, 19);
            this.lPrefix.TabIndex = 2;
            this.lPrefix.Text = "Prefix";
            // 
            // lPermissions
            // 
            this.lPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPermissions.AutoSize = true;
            this.lPermissions.Location = new System.Drawing.Point(488, 60);
            this.lPermissions.Name = "lPermissions";
            this.lPermissions.Size = new System.Drawing.Size(108, 19);
            this.lPermissions.TabIndex = 41;
            this.lPermissions.Text = "Rank Permissions";
            // 
            // bAddRank
            // 
            this.bAddRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bAddRank.Location = new System.Drawing.Point(23, 78);
            this.bAddRank.Name = "bAddRank";
            this.bAddRank.Size = new System.Drawing.Size(70, 23);
            this.bAddRank.TabIndex = 35;
            this.bAddRank.Text = "Add Rank";
            this.bAddRank.UseSelectable = true;
            // 
            // lRankColor
            // 
            this.lRankColor.AutoSize = true;
            this.lRankColor.Location = new System.Drawing.Point(159, 52);
            this.lRankColor.Name = "lRankColor";
            this.lRankColor.Size = new System.Drawing.Size(42, 19);
            this.lRankColor.TabIndex = 5;
            this.lRankColor.Text = "Color";
            // 
            // vRanks
            // 
            this.vRanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.vRanks.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vRanks.FormattingEnabled = true;
            this.vRanks.IntegralHeight = false;
            this.vRanks.ItemHeight = 15;
            this.vRanks.Location = new System.Drawing.Point(23, 107);
            this.vRanks.Name = "vRanks";
            this.vRanks.Size = new System.Drawing.Size(146, 357);
            this.vRanks.TabIndex = 34;
            // 
            // tRankName
            // 
            // 
            // 
            // 
            this.tRankName.CustomButton.Image = null;
            this.tRankName.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tRankName.CustomButton.Name = "";
            this.tRankName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tRankName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tRankName.CustomButton.TabIndex = 1;
            this.tRankName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tRankName.CustomButton.UseSelectable = true;
            this.tRankName.CustomButton.Visible = false;
            this.tRankName.Lines = new string[0];
            this.tRankName.Location = new System.Drawing.Point(62, 20);
            this.tRankName.MaxLength = 16;
            this.tRankName.Name = "tRankName";
            this.tRankName.PasswordChar = '\0';
            this.tRankName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tRankName.SelectedText = "";
            this.tRankName.SelectionLength = 0;
            this.tRankName.SelectionStart = 0;
            this.tRankName.ShortcutsEnabled = true;
            this.tRankName.Size = new System.Drawing.Size(143, 21);
            this.tRankName.TabIndex = 1;
            this.tRankName.UseSelectable = true;
            this.tRankName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tRankName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(488, 403);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(171, 21);
            this.metroButton1.TabIndex = 43;
            this.metroButton1.Text = "Select All";
            this.metroButton1.UseSelectable = true;
            // 
            // lRankList
            // 
            this.lRankList.AutoSize = true;
            this.lRankList.Location = new System.Drawing.Point(23, 60);
            this.lRankList.Name = "lRankList";
            this.lRankList.Size = new System.Drawing.Size(59, 19);
            this.lRankList.TabIndex = 33;
            this.lRankList.Text = "Rank List";
            // 
            // gRankOptions
            // 
            this.gRankOptions.ActiveControl = null;
            this.gRankOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gRankOptions.Controls.Add(this.lFillLimitUnits);
            this.gRankOptions.Controls.Add(this.nFillLimit);
            this.gRankOptions.Controls.Add(this.lFillLimit);
            this.gRankOptions.Controls.Add(this.nCopyPasteSlots);
            this.gRankOptions.Controls.Add(this.lCopyPasteSlots);
            this.gRankOptions.Controls.Add(this.xAllowSecurityCircumvention);
            this.gRankOptions.Controls.Add(this.lAntiGrief1);
            this.gRankOptions.Controls.Add(this.lAntiGrief3);
            this.gRankOptions.Controls.Add(this.nAntiGriefSeconds);
            this.gRankOptions.Controls.Add(this.bColorRank);
            this.gRankOptions.Controls.Add(this.xDrawLimit);
            this.gRankOptions.Controls.Add(this.lDrawLimitUnits);
            this.gRankOptions.Controls.Add(this.lKickIdleUnits);
            this.gRankOptions.Controls.Add(this.nDrawLimit);
            this.gRankOptions.Controls.Add(this.nKickIdle);
            this.gRankOptions.Controls.Add(this.xAntiGrief);
            this.gRankOptions.Controls.Add(this.lAntiGrief2);
            this.gRankOptions.Controls.Add(this.xKickIdle);
            this.gRankOptions.Controls.Add(this.nAntiGriefBlocks);
            this.gRankOptions.Controls.Add(this.xReserveSlot);
            this.gRankOptions.Controls.Add(this.tPrefix);
            this.gRankOptions.Controls.Add(this.lPrefix);
            this.gRankOptions.Controls.Add(this.lRankColor);
            this.gRankOptions.Controls.Add(this.tRankName);
            this.gRankOptions.Controls.Add(this.lRankName);
            this.gRankOptions.Location = new System.Drawing.Point(175, 53);
            this.gRankOptions.Name = "gRankOptions";
            this.gRankOptions.Size = new System.Drawing.Size(307, 273);
            this.gRankOptions.TabIndex = 39;
            this.gRankOptions.TabStop = false;
            this.gRankOptions.Text = "Rank Options";
            this.gRankOptions.UseSelectable = true;
            // 
            // lFillLimitUnits
            // 
            this.lFillLimitUnits.AutoSize = true;
            this.lFillLimitUnits.Location = new System.Drawing.Point(239, 245);
            this.lFillLimitUnits.Name = "lFillLimitUnits";
            this.lFillLimitUnits.Size = new System.Drawing.Size(45, 19);
            this.lFillLimitUnits.TabIndex = 24;
            this.lFillLimitUnits.Text = "blocks";
            // 
            // nFillLimit
            // 
            this.nFillLimit.Location = new System.Drawing.Point(174, 243);
            this.nFillLimit.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nFillLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFillLimit.Name = "nFillLimit";
            this.nFillLimit.Size = new System.Drawing.Size(59, 20);
            this.nFillLimit.TabIndex = 23;
            this.nFillLimit.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lFillLimit
            // 
            this.lFillLimit.AutoSize = true;
            this.lFillLimit.Location = new System.Drawing.Point(85, 245);
            this.lFillLimit.Name = "lFillLimit";
            this.lFillLimit.Size = new System.Drawing.Size(94, 19);
            this.lFillLimit.TabIndex = 22;
            this.lFillLimit.Text = "Flood-fill limit:";
            // 
            // nCopyPasteSlots
            // 
            this.nCopyPasteSlots.Location = new System.Drawing.Point(174, 216);
            this.nCopyPasteSlots.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nCopyPasteSlots.Name = "nCopyPasteSlots";
            this.nCopyPasteSlots.Size = new System.Drawing.Size(59, 20);
            this.nCopyPasteSlots.TabIndex = 21;
            // 
            // lCopyPasteSlots
            // 
            this.lCopyPasteSlots.AutoSize = true;
            this.lCopyPasteSlots.Location = new System.Drawing.Point(50, 218);
            this.lCopyPasteSlots.Name = "lCopyPasteSlots";
            this.lCopyPasteSlots.Size = new System.Drawing.Size(132, 19);
            this.lCopyPasteSlots.TabIndex = 20;
            this.lCopyPasteSlots.Text = "Copy/paste slot limit:";
            // 
            // xAllowSecurityCircumvention
            // 
            this.xAllowSecurityCircumvention.AutoSize = true;
            this.xAllowSecurityCircumvention.Location = new System.Drawing.Point(12, 165);
            this.xAllowSecurityCircumvention.Name = "xAllowSecurityCircumvention";
            this.xAllowSecurityCircumvention.Size = new System.Drawing.Size(266, 15);
            this.xAllowSecurityCircumvention.TabIndex = 16;
            this.xAllowSecurityCircumvention.Text = "Allow removing own access/build restrictions.";
            this.xAllowSecurityCircumvention.UseSelectable = true;
            // 
            // lAntiGrief1
            // 
            this.lAntiGrief1.AutoSize = true;
            this.lAntiGrief1.Location = new System.Drawing.Point(50, 135);
            this.lAntiGrief1.Name = "lAntiGrief1";
            this.lAntiGrief1.Size = new System.Drawing.Size(50, 19);
            this.lAntiGrief1.TabIndex = 11;
            this.lAntiGrief1.Text = "Kick on";
            // 
            // lAntiGrief3
            // 
            this.lAntiGrief3.AutoSize = true;
            this.lAntiGrief3.Location = new System.Drawing.Point(275, 135);
            this.lAntiGrief3.Name = "lAntiGrief3";
            this.lAntiGrief3.Size = new System.Drawing.Size(27, 19);
            this.lAntiGrief3.TabIndex = 15;
            this.lAntiGrief3.Text = "sec";
            // 
            // nAntiGriefSeconds
            // 
            this.nAntiGriefSeconds.Location = new System.Drawing.Point(229, 133);
            this.nAntiGriefSeconds.Name = "nAntiGriefSeconds";
            this.nAntiGriefSeconds.Size = new System.Drawing.Size(40, 20);
            this.nAntiGriefSeconds.TabIndex = 14;
            // 
            // bColorRank
            // 
            this.bColorRank.BackColor = System.Drawing.Color.White;
            this.bColorRank.Location = new System.Drawing.Point(201, 47);
            this.bColorRank.Name = "bColorRank";
            this.bColorRank.Size = new System.Drawing.Size(100, 24);
            this.bColorRank.TabIndex = 6;
            this.bColorRank.UseSelectable = true;
            // 
            // xDrawLimit
            // 
            this.xDrawLimit.AutoSize = true;
            this.xDrawLimit.Location = new System.Drawing.Point(12, 190);
            this.xDrawLimit.Name = "xDrawLimit";
            this.xDrawLimit.Size = new System.Drawing.Size(77, 15);
            this.xDrawLimit.TabIndex = 17;
            this.xDrawLimit.Text = "Draw limit";
            this.xDrawLimit.UseSelectable = true;
            // 
            // lDrawLimitUnits
            // 
            this.lDrawLimitUnits.AutoSize = true;
            this.lDrawLimitUnits.Location = new System.Drawing.Point(172, 191);
            this.lDrawLimitUnits.Name = "lDrawLimitUnits";
            this.lDrawLimitUnits.Size = new System.Drawing.Size(45, 19);
            this.lDrawLimitUnits.TabIndex = 19;
            this.lDrawLimitUnits.Text = "blocks";
            // 
            // lKickIdleUnits
            // 
            this.lKickIdleUnits.AutoSize = true;
            this.lKickIdleUnits.Location = new System.Drawing.Point(181, 79);
            this.lKickIdleUnits.Name = "lKickIdleUnits";
            this.lKickIdleUnits.Size = new System.Drawing.Size(54, 19);
            this.lKickIdleUnits.TabIndex = 9;
            this.lKickIdleUnits.Text = "minutes";
            // 
            // nDrawLimit
            // 
            this.nDrawLimit.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nDrawLimit.Location = new System.Drawing.Point(99, 189);
            this.nDrawLimit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nDrawLimit.Name = "nDrawLimit";
            this.nDrawLimit.Size = new System.Drawing.Size(67, 20);
            this.nDrawLimit.TabIndex = 18;
            // 
            // lRankName
            // 
            this.lRankName.AutoSize = true;
            this.lRankName.Location = new System.Drawing.Point(15, 23);
            this.lRankName.Name = "lRankName";
            this.lRankName.Size = new System.Drawing.Size(45, 19);
            this.lRankName.TabIndex = 0;
            this.lRankName.Text = "Name";
            // 
            // bRaiseRank
            // 
            this.bRaiseRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRaiseRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bRaiseRank.Location = new System.Drawing.Point(23, 470);
            this.bRaiseRank.Name = "bRaiseRank";
            this.bRaiseRank.Size = new System.Drawing.Size(70, 23);
            this.bRaiseRank.TabIndex = 37;
            this.bRaiseRank.Text = "▲ Raise";
            this.bRaiseRank.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(505, 487);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(155, 33);
            this.metroButton2.TabIndex = 45;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(504, 448);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(155, 33);
            this.metroButton3.TabIndex = 44;
            this.metroButton3.Text = "Apply Changes";
            this.metroButton3.UseSelectable = true;
            // 
            // RankConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 555);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.bDeleteRank);
            this.Controls.Add(this.gPermissionLimits);
            this.Controls.Add(this.bLowerRank);
            this.Controls.Add(this.vPermissions);
            this.Controls.Add(this.lPermissions);
            this.Controls.Add(this.bAddRank);
            this.Controls.Add(this.vRanks);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lRankList);
            this.Controls.Add(this.gRankOptions);
            this.Controls.Add(this.bRaiseRank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RankConfig";
            this.Text = "Rank Config";
            this.Load += new System.EventHandler(this.RankConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKickIdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefBlocks)).EndInit();
            this.gPermissionLimits.ResumeLayout(false);
            this.gRankOptions.ResumeLayout(false);
            this.gRankOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFillLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCopyPasteSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAntiGriefSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDrawLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public NumericUpDown nKickIdle;
        public MetroCheckBox xAntiGrief;
        public MetroLabel lAntiGrief2;
        public MetroCheckBox xKickIdle;
        public NumericUpDown nAntiGriefBlocks;
        public MetroCheckBox xReserveSlot;
        public FlowLayoutPanel permissionLimitBoxContainer;
        public MetroButton bDeleteRank;
        public MetroTile gPermissionLimits;
        public MetroButton bLowerRank;
        public MetroTextBox tPrefix;
        public MetroListView vPermissions;
        public ColumnHeader chPermissions;
        public MetroLabel lPrefix;
        public MetroLabel lPermissions;
        public MetroButton bAddRank;
        public MetroLabel lRankColor;
        public ListBox vRanks;
        public MetroTextBox tRankName;
        public MetroButton metroButton1;
        public MetroLabel lRankList;
        public MetroTile gRankOptions;
        public MetroLabel lFillLimitUnits;
        public NumericUpDown nFillLimit;
        public MetroLabel lFillLimit;
        public NumericUpDown nCopyPasteSlots;
        public MetroLabel lCopyPasteSlots;
        public MetroCheckBox xAllowSecurityCircumvention;
        public MetroLabel lAntiGrief1;
        public MetroLabel lAntiGrief3;
        public NumericUpDown nAntiGriefSeconds;
        public MetroButton bColorRank;
        public MetroCheckBox xDrawLimit;
        public MetroLabel lDrawLimitUnits;
        public MetroLabel lKickIdleUnits;
        public NumericUpDown nDrawLimit;
        public MetroLabel lRankName;
        public MetroButton bRaiseRank;
        public MetroButton metroButton2;
        public MetroButton metroButton3;
    }
}