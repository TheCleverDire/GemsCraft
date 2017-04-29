namespace GemsCraftGUI.ConfigGUI.GUITabs.ConfigScreens
{
    partial class Chat
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
            this.chatPreview1 = new fCraft.ConfigGUI.ChatPreview();
            this.gAppearence = new MetroFramework.Controls.MetroTile();
            this.xShowConnectionMessages = new System.Windows.Forms.CheckBox();
            this.xShowJoinedWorldMessages = new System.Windows.Forms.CheckBox();
            this.xRankColorsInWorldNames = new System.Windows.Forms.CheckBox();
            this.xRankPrefixesInList = new System.Windows.Forms.CheckBox();
            this.xRankPrefixesInChat = new System.Windows.Forms.CheckBox();
            this.xRankColorsInChat = new System.Windows.Forms.CheckBox();
            this.gChatColors = new MetroFramework.Controls.MetroTile();
            this.lColorMe = new MetroFramework.Controls.MetroLabel();
            this.bColorGlobal = new MetroFramework.Controls.MetroButton();
            this.bColorMe = new MetroFramework.Controls.MetroButton();
            this.lColorWarning = new MetroFramework.Controls.MetroLabel();
            this.bColorWarning = new MetroFramework.Controls.MetroButton();
            this.bColorSys = new MetroFramework.Controls.MetroButton();
            this.lColorSys = new MetroFramework.Controls.MetroLabel();
            this.bColorPM = new MetroFramework.Controls.MetroButton();
            this.lColorHelp = new MetroFramework.Controls.MetroLabel();
            this.lColorPM = new MetroFramework.Controls.MetroLabel();
            this.IColorGlobal = new MetroFramework.Controls.MetroLabel();
            this.lColorSay = new MetroFramework.Controls.MetroLabel();
            this.bColorAnnouncement = new MetroFramework.Controls.MetroButton();
            this.lColorAnnouncement = new MetroFramework.Controls.MetroLabel();
            this.bColorHelp = new MetroFramework.Controls.MetroButton();
            this.bColorSay = new MetroFramework.Controls.MetroButton();
            this.gAppearence.SuspendLayout();
            this.gChatColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatPreview1
            // 
            this.chatPreview1.AutoScroll = true;
            this.chatPreview1.Location = new System.Drawing.Point(22, 336);
            this.chatPreview1.Name = "chatPreview1";
            this.chatPreview1.Size = new System.Drawing.Size(637, 222);
            this.chatPreview1.TabIndex = 5;
            // 
            // gAppearence
            // 
            this.gAppearence.ActiveControl = null;
            this.gAppearence.Controls.Add(this.xShowConnectionMessages);
            this.gAppearence.Controls.Add(this.xShowJoinedWorldMessages);
            this.gAppearence.Controls.Add(this.xRankColorsInWorldNames);
            this.gAppearence.Controls.Add(this.xRankPrefixesInList);
            this.gAppearence.Controls.Add(this.xRankPrefixesInChat);
            this.gAppearence.Controls.Add(this.xRankColorsInChat);
            this.gAppearence.Location = new System.Drawing.Point(22, 208);
            this.gAppearence.Name = "gAppearence";
            this.gAppearence.Size = new System.Drawing.Size(637, 122);
            this.gAppearence.TabIndex = 4;
            this.gAppearence.TabStop = false;
            this.gAppearence.Text = "Appearence Tweaks";
            this.gAppearence.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.gAppearence.UseSelectable = true;
            // 
            // xShowConnectionMessages
            // 
            this.xShowConnectionMessages.AutoSize = true;
            this.xShowConnectionMessages.BackColor = System.Drawing.Color.Transparent;
            this.xShowConnectionMessages.Location = new System.Drawing.Point(325, 45);
            this.xShowConnectionMessages.Name = "xShowConnectionMessages";
            this.xShowConnectionMessages.Size = new System.Drawing.Size(272, 17);
            this.xShowConnectionMessages.TabIndex = 4;
            this.xShowConnectionMessages.Text = "Show a message when players join/leave SERVER.";
            this.xShowConnectionMessages.UseVisualStyleBackColor = false;
            // 
            // xShowJoinedWorldMessages
            // 
            this.xShowJoinedWorldMessages.AutoSize = true;
            this.xShowJoinedWorldMessages.BackColor = System.Drawing.Color.Transparent;
            this.xShowJoinedWorldMessages.Location = new System.Drawing.Point(325, 20);
            this.xShowJoinedWorldMessages.Name = "xShowJoinedWorldMessages";
            this.xShowJoinedWorldMessages.Size = new System.Drawing.Size(227, 17);
            this.xShowJoinedWorldMessages.TabIndex = 3;
            this.xShowJoinedWorldMessages.Text = "Show a message when players join worlds.";
            this.xShowJoinedWorldMessages.UseVisualStyleBackColor = false;
            // 
            // xRankColorsInWorldNames
            // 
            this.xRankColorsInWorldNames.AutoSize = true;
            this.xRankColorsInWorldNames.BackColor = System.Drawing.Color.Transparent;
            this.xRankColorsInWorldNames.Location = new System.Drawing.Point(325, 70);
            this.xRankColorsInWorldNames.Name = "xRankColorsInWorldNames";
            this.xRankColorsInWorldNames.Size = new System.Drawing.Size(211, 17);
            this.xRankColorsInWorldNames.TabIndex = 5;
            this.xRankColorsInWorldNames.Text = "Color world names based on build rank.";
            this.xRankColorsInWorldNames.UseVisualStyleBackColor = false;
            // 
            // xRankPrefixesInList
            // 
            this.xRankPrefixesInList.AutoSize = true;
            this.xRankPrefixesInList.BackColor = System.Drawing.Color.Transparent;
            this.xRankPrefixesInList.Location = new System.Drawing.Point(44, 70);
            this.xRankPrefixesInList.Name = "xRankPrefixesInList";
            this.xRankPrefixesInList.Size = new System.Drawing.Size(191, 17);
            this.xRankPrefixesInList.TabIndex = 2;
            this.xRankPrefixesInList.Text = "Prefixes in player list (breaks skins).";
            this.xRankPrefixesInList.UseVisualStyleBackColor = false;
            // 
            // xRankPrefixesInChat
            // 
            this.xRankPrefixesInChat.AutoSize = true;
            this.xRankPrefixesInChat.BackColor = System.Drawing.Color.Transparent;
            this.xRankPrefixesInChat.Location = new System.Drawing.Point(25, 45);
            this.xRankPrefixesInChat.Name = "xRankPrefixesInChat";
            this.xRankPrefixesInChat.Size = new System.Drawing.Size(119, 17);
            this.xRankPrefixesInChat.TabIndex = 1;
            this.xRankPrefixesInChat.Text = "Show rank prefixes.";
            this.xRankPrefixesInChat.UseVisualStyleBackColor = false;
            // 
            // xRankColorsInChat
            // 
            this.xRankColorsInChat.AutoSize = true;
            this.xRankColorsInChat.BackColor = System.Drawing.Color.Transparent;
            this.xRankColorsInChat.Location = new System.Drawing.Point(25, 20);
            this.xRankColorsInChat.Name = "xRankColorsInChat";
            this.xRankColorsInChat.Size = new System.Drawing.Size(111, 17);
            this.xRankColorsInChat.TabIndex = 0;
            this.xRankColorsInChat.Text = "Show rank colors.";
            this.xRankColorsInChat.UseVisualStyleBackColor = false;
            // 
            // gChatColors
            // 
            this.gChatColors.ActiveControl = null;
            this.gChatColors.BackColor = System.Drawing.Color.Gray;
            this.gChatColors.Controls.Add(this.lColorMe);
            this.gChatColors.Controls.Add(this.bColorGlobal);
            this.gChatColors.Controls.Add(this.bColorMe);
            this.gChatColors.Controls.Add(this.lColorWarning);
            this.gChatColors.Controls.Add(this.bColorWarning);
            this.gChatColors.Controls.Add(this.bColorSys);
            this.gChatColors.Controls.Add(this.lColorSys);
            this.gChatColors.Controls.Add(this.bColorPM);
            this.gChatColors.Controls.Add(this.lColorHelp);
            this.gChatColors.Controls.Add(this.lColorPM);
            this.gChatColors.Controls.Add(this.IColorGlobal);
            this.gChatColors.Controls.Add(this.lColorSay);
            this.gChatColors.Controls.Add(this.bColorAnnouncement);
            this.gChatColors.Controls.Add(this.lColorAnnouncement);
            this.gChatColors.Controls.Add(this.bColorHelp);
            this.gChatColors.Controls.Add(this.bColorSay);
            this.gChatColors.Location = new System.Drawing.Point(23, 63);
            this.gChatColors.Name = "gChatColors";
            this.gChatColors.Size = new System.Drawing.Size(636, 139);
            this.gChatColors.TabIndex = 3;
            this.gChatColors.TabStop = false;
            this.gChatColors.Text = "Colors";
            this.gChatColors.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.gChatColors.UseSelectable = true;
            // 
            // lColorMe
            // 
            this.lColorMe.AutoSize = true;
            this.lColorMe.Location = new System.Drawing.Point(388, 78);
            this.lColorMe.Name = "lColorMe";
            this.lColorMe.Size = new System.Drawing.Size(131, 19);
            this.lColorMe.TabIndex = 12;
            this.lColorMe.Text = "/Me command color";
            // 
            // bColorGlobal
            // 
            this.bColorGlobal.BackColor = System.Drawing.Color.White;
            this.bColorGlobal.Location = new System.Drawing.Point(525, 111);
            this.bColorGlobal.Name = "bColorGlobal";
            this.bColorGlobal.Size = new System.Drawing.Size(100, 23);
            this.bColorGlobal.TabIndex = 13;
            this.bColorGlobal.UseSelectable = true;
            // 
            // bColorMe
            // 
            this.bColorMe.BackColor = System.Drawing.Color.White;
            this.bColorMe.Location = new System.Drawing.Point(525, 78);
            this.bColorMe.Name = "bColorMe";
            this.bColorMe.Size = new System.Drawing.Size(100, 23);
            this.bColorMe.TabIndex = 13;
            this.bColorMe.UseSelectable = true;
            // 
            // lColorWarning
            // 
            this.lColorWarning.AutoSize = true;
            this.lColorWarning.Location = new System.Drawing.Point(52, 49);
            this.lColorWarning.Name = "lColorWarning";
            this.lColorWarning.Size = new System.Drawing.Size(135, 19);
            this.lColorWarning.TabIndex = 2;
            this.lColorWarning.Text = "Warning / error color";
            // 
            // bColorWarning
            // 
            this.bColorWarning.BackColor = System.Drawing.Color.White;
            this.bColorWarning.Location = new System.Drawing.Point(193, 49);
            this.bColorWarning.Name = "bColorWarning";
            this.bColorWarning.Size = new System.Drawing.Size(100, 23);
            this.bColorWarning.TabIndex = 3;
            this.bColorWarning.UseSelectable = true;
            // 
            // bColorSys
            // 
            this.bColorSys.BackColor = System.Drawing.Color.White;
            this.bColorSys.Location = new System.Drawing.Point(193, 20);
            this.bColorSys.Name = "bColorSys";
            this.bColorSys.Size = new System.Drawing.Size(100, 23);
            this.bColorSys.TabIndex = 1;
            this.bColorSys.UseSelectable = true;
            // 
            // lColorSys
            // 
            this.lColorSys.AutoSize = true;
            this.lColorSys.Location = new System.Drawing.Point(48, 20);
            this.lColorSys.Name = "lColorSys";
            this.lColorSys.Size = new System.Drawing.Size(139, 19);
            this.lColorSys.TabIndex = 0;
            this.lColorSys.Text = "System message color";
            // 
            // bColorPM
            // 
            this.bColorPM.BackColor = System.Drawing.Color.White;
            this.bColorPM.Location = new System.Drawing.Point(193, 78);
            this.bColorPM.Name = "bColorPM";
            this.bColorPM.Size = new System.Drawing.Size(100, 23);
            this.bColorPM.TabIndex = 5;
            this.bColorPM.UseSelectable = true;
            // 
            // lColorHelp
            // 
            this.lColorHelp.AutoSize = true;
            this.lColorHelp.Location = new System.Drawing.Point(62, 107);
            this.lColorHelp.Name = "lColorHelp";
            this.lColorHelp.Size = new System.Drawing.Size(125, 19);
            this.lColorHelp.TabIndex = 6;
            this.lColorHelp.Text = "Help message color";
            // 
            // lColorPM
            // 
            this.lColorPM.AutoSize = true;
            this.lColorPM.Location = new System.Drawing.Point(11, 78);
            this.lColorPM.Name = "lColorPM";
            this.lColorPM.Size = new System.Drawing.Size(176, 19);
            this.lColorPM.TabIndex = 4;
            this.lColorPM.Text = "Private / rank message color";
            // 
            // IColorGlobal
            // 
            this.IColorGlobal.AutoSize = true;
            this.IColorGlobal.Location = new System.Drawing.Point(404, 111);
            this.IColorGlobal.Name = "IColorGlobal";
            this.IColorGlobal.Size = new System.Drawing.Size(115, 19);
            this.IColorGlobal.TabIndex = 10;
            this.IColorGlobal.Text = "Global Chat Color";
            // 
            // lColorSay
            // 
            this.lColorSay.AutoSize = true;
            this.lColorSay.Location = new System.Drawing.Point(396, 49);
            this.lColorSay.Name = "lColorSay";
            this.lColorSay.Size = new System.Drawing.Size(123, 19);
            this.lColorSay.TabIndex = 10;
            this.lColorSay.Text = "/Say message color";
            // 
            // bColorAnnouncement
            // 
            this.bColorAnnouncement.BackColor = System.Drawing.Color.White;
            this.bColorAnnouncement.Location = new System.Drawing.Point(525, 20);
            this.bColorAnnouncement.Name = "bColorAnnouncement";
            this.bColorAnnouncement.Size = new System.Drawing.Size(100, 23);
            this.bColorAnnouncement.TabIndex = 9;
            this.bColorAnnouncement.UseSelectable = true;
            // 
            // lColorAnnouncement
            // 
            this.lColorAnnouncement.AutoSize = true;
            this.lColorAnnouncement.Location = new System.Drawing.Point(323, 20);
            this.lColorAnnouncement.Name = "lColorAnnouncement";
            this.lColorAnnouncement.Size = new System.Drawing.Size(196, 19);
            this.lColorAnnouncement.TabIndex = 8;
            this.lColorAnnouncement.Text = "Announcement and /Rules color";
            // 
            // bColorHelp
            // 
            this.bColorHelp.BackColor = System.Drawing.Color.White;
            this.bColorHelp.Location = new System.Drawing.Point(193, 107);
            this.bColorHelp.Name = "bColorHelp";
            this.bColorHelp.Size = new System.Drawing.Size(100, 23);
            this.bColorHelp.TabIndex = 7;
            this.bColorHelp.UseSelectable = true;
            // 
            // bColorSay
            // 
            this.bColorSay.BackColor = System.Drawing.Color.White;
            this.bColorSay.Location = new System.Drawing.Point(525, 49);
            this.bColorSay.Name = "bColorSay";
            this.bColorSay.Size = new System.Drawing.Size(100, 23);
            this.bColorSay.TabIndex = 11;
            this.bColorSay.UseSelectable = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 590);
            this.Controls.Add(this.chatPreview1);
            this.Controls.Add(this.gAppearence);
            this.Controls.Add(this.gChatColors);
            this.Name = "Chat";
            this.Text = "Chat";
            this.gAppearence.ResumeLayout(false);
            this.gAppearence.PerformLayout();
            this.gChatColors.ResumeLayout(false);
            this.gChatColors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal fCraft.ConfigGUI.ChatPreview chatPreview1;
        internal MetroFramework.Controls.MetroTile gAppearence;
        internal System.Windows.Forms.CheckBox xShowConnectionMessages;
        internal System.Windows.Forms.CheckBox xShowJoinedWorldMessages;
        internal System.Windows.Forms.CheckBox xRankColorsInWorldNames;
        internal System.Windows.Forms.CheckBox xRankPrefixesInList;
        internal System.Windows.Forms.CheckBox xRankPrefixesInChat;
        internal System.Windows.Forms.CheckBox xRankColorsInChat;
        internal MetroFramework.Controls.MetroTile gChatColors;
        internal MetroFramework.Controls.MetroLabel lColorMe;
        internal MetroFramework.Controls.MetroButton bColorGlobal;
        internal MetroFramework.Controls.MetroButton bColorMe;
        internal MetroFramework.Controls.MetroLabel lColorWarning;
        internal MetroFramework.Controls.MetroButton bColorWarning;
        internal MetroFramework.Controls.MetroButton bColorSys;
        internal MetroFramework.Controls.MetroLabel lColorSys;
        internal MetroFramework.Controls.MetroButton bColorPM;
        internal MetroFramework.Controls.MetroLabel lColorHelp;
        internal MetroFramework.Controls.MetroLabel lColorPM;
        internal MetroFramework.Controls.MetroLabel IColorGlobal;
        internal MetroFramework.Controls.MetroLabel lColorSay;
        internal MetroFramework.Controls.MetroButton bColorAnnouncement;
        internal MetroFramework.Controls.MetroLabel lColorAnnouncement;
        internal MetroFramework.Controls.MetroButton bColorHelp;
        internal MetroFramework.Controls.MetroButton bColorSay;
    }
}