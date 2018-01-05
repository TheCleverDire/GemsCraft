using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GemsCraftGUI
{
    public partial class PB : PictureBox
    {
        public PB()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (Bitmap bmp = new Bitmap(100, 100))
            {
                
                ColorMap[] colorMap = new ColorMap[1];
                colorMap[0] = new ColorMap();
                colorMap[0].OldColor = Color.White;
                colorMap[0].NewColor = Color.FromArgb(255, 180, 198, 231);
                ImageAttributes attr = new ImageAttributes();
                attr.SetRemapTable(colorMap);
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                pe.Graphics.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            }
        }
    }
}
