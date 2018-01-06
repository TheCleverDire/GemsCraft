namespace GemsCraft.GUI
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.btnNewServer = new MetroFramework.Controls.MetroButton();
            this.btnDeleteServer = new MetroFramework.Controls.MetroButton();
            this.btnImportServer = new MetroFramework.Controls.MetroButton();
            this.btnMoveDirectory = new MetroFramework.Controls.MetroButton();
            this.serverBox = new System.Windows.Forms.ListBox();
            this.ImportServerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MoveServerDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnOpenServer = new MetroFramework.Controls.MetroButton();
            this.openTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNewServer
            // 
            this.btnNewServer.Location = new System.Drawing.Point(15, 103);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(163, 34);
            this.btnNewServer.TabIndex = 0;
            this.btnNewServer.Text = "New Server";
            this.btnNewServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNewServer.UseSelectable = true;
            this.btnNewServer.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Location = new System.Drawing.Point(15, 143);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(163, 34);
            this.btnDeleteServer.TabIndex = 1;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDeleteServer.UseSelectable = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // btnImportServer
            // 
            this.btnImportServer.Location = new System.Drawing.Point(15, 183);
            this.btnImportServer.Name = "btnImportServer";
            this.btnImportServer.Size = new System.Drawing.Size(163, 34);
            this.btnImportServer.TabIndex = 2;
            this.btnImportServer.Text = "Import Server";
            this.btnImportServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImportServer.UseSelectable = true;
            this.btnImportServer.Click += new System.EventHandler(this.btnImportServer_Click);
            // 
            // btnMoveDirectory
            // 
            this.btnMoveDirectory.Location = new System.Drawing.Point(15, 223);
            this.btnMoveDirectory.Name = "btnMoveDirectory";
            this.btnMoveDirectory.Size = new System.Drawing.Size(163, 34);
            this.btnMoveDirectory.TabIndex = 3;
            this.btnMoveDirectory.Text = "Move Server";
            this.btnMoveDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnMoveDirectory.UseSelectable = true;
            this.btnMoveDirectory.Click += new System.EventHandler(this.btnMoveDirectory_Click);
            // 
            // serverBox
            // 
            this.serverBox.FormattingEnabled = true;
            this.serverBox.Location = new System.Drawing.Point(184, 63);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(179, 264);
            this.serverBox.TabIndex = 4;
            // 
            // ImportServerDialog
            // 
            this.ImportServerDialog.Description = "Select the location of your server";
            // 
            // MoveServerDialog
            // 
            this.MoveServerDialog.Description = "Select the location of your server";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(15, 260);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(163, 64);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.WrapToLine = true;
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Location = new System.Drawing.Point(15, 63);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(163, 34);
            this.btnOpenServer.TabIndex = 6;
            this.btnOpenServer.Text = "Open Server";
            this.btnOpenServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOpenServer.UseSelectable = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // openTimer
            // 
            this.openTimer.Enabled = true;
            this.openTimer.Interval = 1;
            this.openTimer.Tick += new System.EventHandler(this.openTimer_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 350);
            this.Controls.Add(this.btnOpenServer);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.btnMoveDirectory);
            this.Controls.Add(this.btnImportServer);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.btnNewServer);
            this.Name = "MainScreen";
            this.Text = "GemsCraft";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNewServer;
        private MetroFramework.Controls.MetroButton btnDeleteServer;
        private MetroFramework.Controls.MetroButton btnImportServer;
        private MetroFramework.Controls.MetroButton btnMoveDirectory;
        private System.Windows.Forms.ListBox serverBox;
        private System.Windows.Forms.FolderBrowserDialog ImportServerDialog;
        private System.Windows.Forms.FolderBrowserDialog MoveServerDialog;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnOpenServer;
        private System.Windows.Forms.Timer openTimer;
    }
}