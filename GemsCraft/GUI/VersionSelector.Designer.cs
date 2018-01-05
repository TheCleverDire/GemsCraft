namespace GemsCraftGUI
{
    partial class VersionSelector
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
            this.chkAlpha = new MetroFramework.Controls.MetroCheckBox();
            this.chkBeta = new MetroFramework.Controls.MetroCheckBox();
            this.versionBox = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // chkAlpha
            // 
            this.chkAlpha.AutoSize = true;
            this.chkAlpha.Location = new System.Drawing.Point(24, 64);
            this.chkAlpha.Name = "chkAlpha";
            this.chkAlpha.Size = new System.Drawing.Size(132, 15);
            this.chkAlpha.TabIndex = 0;
            this.chkAlpha.Text = "Show Alpha Versions";
            this.chkAlpha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkAlpha.UseSelectable = true;
            this.chkAlpha.CheckedChanged += new System.EventHandler(this.chkAlpha_CheckedChanged);
            // 
            // chkBeta
            // 
            this.chkBeta.AutoSize = true;
            this.chkBeta.Location = new System.Drawing.Point(24, 85);
            this.chkBeta.Name = "chkBeta";
            this.chkBeta.Size = new System.Drawing.Size(124, 15);
            this.chkBeta.TabIndex = 1;
            this.chkBeta.Text = "Show Beta Versions";
            this.chkBeta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkBeta.UseSelectable = true;
            this.chkBeta.CheckedChanged += new System.EventHandler(this.chkBeta_CheckedChanged);
            // 
            // versionBox
            // 
            this.versionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Location = new System.Drawing.Point(24, 107);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(174, 134);
            this.versionBox.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 250);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(174, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Select";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // VersionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 296);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.chkBeta);
            this.Controls.Add(this.chkAlpha);
            this.Name = "VersionSelector";
            this.Text = "Select Version";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.VersionSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkAlpha;
        private MetroFramework.Controls.MetroCheckBox chkBeta;
        private System.Windows.Forms.ListBox versionBox;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}