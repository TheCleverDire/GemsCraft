using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GemsCraft
{
    public enum ApplicationType
    {
        Legacy, Modern
    }
    public class Server
    {
        [JsonProperty] public string Name;
        [JsonProperty] public string Dir;
        [JsonProperty] public string SoftwareVersion;
        [JsonProperty] public ApplicationType TypeOfGems;

        public void OpenApplication()
        {
            var path = TypeOfGems == ApplicationType.Legacy ? Dir + "ServerGUI.exe" : Dir + "GemsCraftGUI.exe";
            Process.Start(path);
        }
    }
    
}
