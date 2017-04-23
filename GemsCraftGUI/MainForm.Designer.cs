using GemsCraftGUI.ConfigGUI;
using MetroFramework.Controls;
using System.Windows.Forms;
using static GemsCraftGUI.Program;
namespace GemsCraftGUI
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.ServerTab = new MetroFramework.Controls.MetroTabPage();
            this.ThemeBox = new MetroFramework.Controls.MetroComboBox();
            this.btnRestart = new MetroFramework.Controls.MetroButton();
            this.pStop = new MetroFramework.Controls.MetroButton();
            this.bStart = new MetroFramework.Controls.MetroButton();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.playerListLabel = new MetroFramework.Controls.MetroLabel();
            this.bVoice = new MetroFramework.Controls.MetroButton();
            this.console = new fCraft.ServerGUI.ConsoleBox();
            this.picServerStatus = new System.Windows.Forms.PictureBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.URLLabel = new MetroFramework.Controls.MetroLabel();
            this.bPlay = new MetroFramework.Controls.MetroButton();
            this.uriDisplay = new MetroFramework.Controls.MetroTextBox();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.ServerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServerTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 550);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // ServerTab
            // 
            this.ServerTab.BackColor = System.Drawing.Color.Gray;
            this.ServerTab.Controls.Add(this.ThemeBox);
            this.ServerTab.Controls.Add(this.btnRestart);
            this.ServerTab.Controls.Add(this.pStop);
            this.ServerTab.Controls.Add(this.bStart);
            this.ServerTab.Controls.Add(this.logBox);
            this.ServerTab.Controls.Add(this.playerListLabel);
            this.ServerTab.Controls.Add(this.bVoice);
            this.ServerTab.Controls.Add(this.console);
            this.ServerTab.Controls.Add(this.picServerStatus);
            this.ServerTab.Controls.Add(this.playerList);
            this.ServerTab.Controls.Add(this.URLLabel);
            this.ServerTab.Controls.Add(this.bPlay);
            this.ServerTab.Controls.Add(this.uriDisplay);
            this.ServerTab.HorizontalScrollbarBarColor = true;
            this.ServerTab.HorizontalScrollbarHighlightOnWheel = false;
            this.ServerTab.HorizontalScrollbarSize = 10;
            this.ServerTab.Location = new System.Drawing.Point(4, 38);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTab.Size = new System.Drawing.Size(679, 508);
            this.ServerTab.TabIndex = 1;
            this.ServerTab.Text = "Server";
            this.ServerTab.VerticalScrollbarBarColor = true;
            this.ServerTab.VerticalScrollbarHighlightOnWheel = false;
            this.ServerTab.VerticalScrollbarSize = 10;
            this.ServerTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ThemeBox
            // 
            this.ThemeBox.FormattingEnabled = true;
            this.ThemeBox.ItemHeight = 23;
            this.ThemeBox.Location = new System.Drawing.Point(546, 205);
            this.ThemeBox.Name = "ThemeBox";
            this.ThemeBox.Size = new System.Drawing.Size(121, 29);
            this.ThemeBox.TabIndex = 20;
            this.ThemeBox.UseSelectable = true;
            this.ThemeBox.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(542, 62);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(137, 23);
            this.btnRestart.TabIndex = 18;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseSelectable = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pStop
            // 
            this.pStop.Enabled = false;
            this.pStop.Location = new System.Drawing.Point(542, 34);
            this.pStop.Name = "pStop";
            this.pStop.Size = new System.Drawing.Size(137, 23);
            this.pStop.TabIndex = 17;
            this.pStop.Text = "Stop";
            this.pStop.UseSelectable = true;
            this.pStop.Click += new System.EventHandler(this.pStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(541, 6);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(137, 23);
            this.bStart.TabIndex = 16;
            this.bStart.Text = "Start";
            this.bStart.UseSelectable = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.Enabled = false;
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.HideSelection = false;
            this.logBox.Location = new System.Drawing.Point(11, 32);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(525, 444);
            this.logBox.TabIndex = 14;
            this.logBox.Text = "";
            // 
            // playerListLabel
            // 
            this.playerListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerListLabel.AutoSize = true;
            this.playerListLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerListLabel.ForeColor = System.Drawing.Color.Black;
            this.playerListLabel.Location = new System.Drawing.Point(546, 237);
            this.playerListLabel.Name = "playerListLabel";
            this.playerListLabel.Size = new System.Drawing.Size(64, 19);
            this.playerListLabel.TabIndex = 12;
            this.playerListLabel.Text = "Player list";
            this.playerListLabel.Click += new System.EventHandler(this.playerListLabel_Click);
            // 
            // bVoice
            // 
            this.bVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bVoice.Enabled = false;
            this.bVoice.Location = new System.Drawing.Point(642, 471);
            this.bVoice.Name = "bVoice";
            this.bVoice.Size = new System.Drawing.Size(37, 31);
            this.bVoice.TabIndex = 13;
            this.bVoice.Text = "V";
            this.bVoice.UseSelectable = true;
            this.bVoice.Visible = false;
            // 
            // console
            // 
            this.console.Enabled = false;
            this.console.Location = new System.Drawing.Point(11, 482);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(667, 20);
            this.console.TabIndex = 15;
            // 
            // picServerStatus
            // 
            this.picServerStatus.Image = global::GemsCraftGUI.Properties.Resources.server_off;
            this.picServerStatus.Location = new System.Drawing.Point(541, 91);
            this.picServerStatus.Name = "picServerStatus";
            this.picServerStatus.Size = new System.Drawing.Size(138, 143);
            this.picServerStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picServerStatus.TabIndex = 19;
            this.picServerStatus.TabStop = false;
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.BackColor = System.Drawing.Color.Silver;
            this.playerList.Enabled = false;
            this.playerList.FormattingEnabled = true;
            this.playerList.IntegralHeight = false;
            this.playerList.Location = new System.Drawing.Point(541, 259);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(138, 217);
            this.playerList.TabIndex = 11;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.ForeColor = System.Drawing.Color.Black;
            this.URLLabel.Location = new System.Drawing.Point(7, 10);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(35, 19);
            this.URLLabel.TabIndex = 9;
            this.URLLabel.Text = "URL:";
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bPlay.Enabled = false;
            this.bPlay.Location = new System.Drawing.Point(488, 6);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(48, 20);
            this.bPlay.TabIndex = 8;
            this.bPlay.Text = "Play";
            this.bPlay.UseSelectable = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // uriDisplay
            // 
            // 
            // 
            // 
            this.uriDisplay.CustomButton.Image = null;
            this.uriDisplay.CustomButton.Location = new System.Drawing.Point(416, 2);
            this.uriDisplay.CustomButton.Name = "";
            this.uriDisplay.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.uriDisplay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uriDisplay.CustomButton.TabIndex = 1;
            this.uriDisplay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uriDisplay.CustomButton.UseSelectable = true;
            this.uriDisplay.CustomButton.Visible = false;
            this.uriDisplay.Enabled = false;
            this.uriDisplay.Lines = new string[0];
            this.uriDisplay.Location = new System.Drawing.Point(48, 6);
            this.uriDisplay.MaxLength = 32767;
            this.uriDisplay.Name = "uriDisplay";
            this.uriDisplay.PasswordChar = '\0';
            this.uriDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uriDisplay.SelectedText = "";
            this.uriDisplay.SelectionLength = 0;
            this.uriDisplay.SelectionStart = 0;
            this.uriDisplay.ShortcutsEnabled = true;
            this.uriDisplay.Size = new System.Drawing.Size(434, 20);
            this.uriDisplay.TabIndex = 10;
            this.uriDisplay.UseSelectable = true;
            this.uriDisplay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uriDisplay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 11111;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 637);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "GemsCraft";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.ServerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picServerStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroTabControl tabControl1;
        internal MetroTabPage ServerTab;
        internal ToolTip toolTip;
        internal ToolTip toolTip1;
        internal MetroLabel URLLabel;
        internal MetroButton bPlay;
        internal MetroTextBox uriDisplay;
        internal MetroLabel playerListLabel;
        internal ListBox playerList;
        internal MetroButton bVoice;
        internal RichTextBox logBox;
        internal fCraft.ServerGUI.ConsoleBox console;
        internal MetroButton bStart;
        internal MetroButton pStop;
        internal MetroButton btnRestart;
        internal PictureBox picServerStatus;
        
        internal MetroComboBox ThemeBox;
        internal MetroTabPage tabPage1;
        internal MetroComboBox cinternal;
        internal MetroLabel linternal;
    }


}