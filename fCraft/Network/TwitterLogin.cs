using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fCraft.Network;
using MetroFramework.Forms;

namespace GemsCraftGUI.fCraftGUI
{
    public partial class TwitterLogin : MetroForm
    {
        public TwitterLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageBox.Show("Please do not leave the pin empty.");
            }
            else
            {
                SocialMedia.UsedTwitterPin = txtUsername.Text;
                Close();
            }

        }
    }
}
