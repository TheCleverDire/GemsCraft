using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using fCraft;
using ICSharpCode.SharpZipLib.Zip;

namespace GemzLauncher
{
    public partial class DownloadForm : Form
    {
        private readonly string _extractPath;
        private readonly string _tempName;
        public DownloadForm(string url, string extractPath)
        {
            InitializeComponent();
            _extractPath = extractPath;
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;

            // Starts the download
            _tempName = DateTime.Now.ToLongDateString().CalculateMd5Hash() + ".zip";
            client.DownloadFileAsync(new Uri(url), _tempName);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Extracting Files now...");
            
            using (var s = new ZipInputStream(File.OpenRead(_tempName)))
            {
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    Console.WriteLine(theEntry.Name);

                    var directoryName = _extractPath;
                    var fileName = Path.GetFileName(theEntry.Name);

                    // create directory
                    if (directoryName.Length > 0)
                    {
                        if (!Directory.Exists(_extractPath)) Directory.CreateDirectory(_extractPath);
                        else
                        {
                            foreach (var file in Directory.GetFiles(_extractPath))
                            {
                                var f = Path.GetFileName(file).ToLower();
                                if (f == "gemscraftgui.exe" || f == "servercli.exe" ||
                                    f == "servergui.exe" || f == "tutorial.exe" ||
                                    Path.GetExtension(file).Replace(".", "").ToLower() == "dll")
                                {
                                    File.Delete(file); // Clean out directory
                                }
                            }
                        }
                    }

                    if (fileName == string.Empty) continue;
                    var fullPath = directoryName + "\\" + fileName;
                    using (var streamWriter = File.Create(fullPath))
                    {
                        var data = new byte[2048];
                        while (true)
                        {
                            var size = s.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            File.Delete(_tempName); // Delete temp zip archive
            Close();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                var bytesIn = double.Parse(e.BytesReceived.ToString());
                var totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                var percentage = bytesIn / totalBytes * 100;

                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
