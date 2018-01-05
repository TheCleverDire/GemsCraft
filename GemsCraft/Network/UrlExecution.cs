using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GemsCraft.Network
{
    public class UrlExecution
    {
        public static string Execute(string url)
        {
            using (var client = new WebClient())
            {
                var result = client.DownloadString(url);
                return result;
            }
        }

        public static string Download(string url, string path, bool showForm)
        {
            throw new NotImplementedException();
        }
    }
}
