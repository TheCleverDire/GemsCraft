using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GemsCraft.GUI
{
    public partial class DownloadForm : MetroForm
    {
        private readonly string[] _fileList;
        private readonly string[] _fileNames;
        public DownloadForm(string url, string fileName)
        {
            InitializeComponent();
            _fileList = new[] {url};
            _fileNames = new[] {fileName};
            Load += Begin;
        }

        private int currentOne = 0;
        private void Begin(object sender, EventArgs e)
        {
            Thread t = new Thread(Start) {Name = "Download"};
            t.Start();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += Tick;
            timer.Interval = 1;
            timer.Enabled = true;
            timer.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = metroLabel1.Text.Replace("{0}", _fileList[currentOne]);
        }

        public DownloadForm(string[] urls, string[] fileNames)
        {
            InitializeComponent();
            _fileList = urls;
            _fileNames = fileNames;
            Load += Begin;
        }

        private void Start()
        {
            using (var client = new WebClient())
            {
                client.DownloadFileCompleted += Completed;
                for (int x = 0; x <= _fileList.Length - 1; x++)
                {
                    currentOne = x;
                    client.DownloadFileAsync(new Uri(_fileList[x]), _fileNames[x]);
                }
                
            }
        }

        private int count = 0;
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            count++;
            if (count == _fileList.Length)
            {
                BeginInvoke(new HideDel(HideForm));
            }
        }

        private void HideForm()
        {
            Close();
        }

        private delegate void HideDel();
    }

}
