
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace fCraft.UpdateBuilder {
    static class Program {

        static readonly string[] FileList = {
            "AStarPathFinder.dll",
            "GemsCraftGUI.exe",
            "fCraft.dll",
            "fCraftGUI.dll",
            "ServerCLI.exe",
            "ServiceStack.Text.dll"
        };

        static string _binariesFileName;


        static void Main()
        {
            _binariesFileName = "Releases/" + fCraft.Updater.LatestStable + ".zip";
            FileInfo binaries = new FileInfo(_binariesFileName);
            try
            {
                File.Delete(_binariesFileName);
            }
            catch (FileNotFoundException ex)
            {
                //File not found. All is good
            }

            using (ZipStorer zs = ZipStorer.Create(binaries.FullName, ""))
            {
                foreach (FileInfo fi in FileList.Select(file => new FileInfo(file)))
                {
                    if (!fi.Exists)
                    {
                        return; // abort if any of the files do not exist
                    }
                    zs.AddFile(ZipStorer.Compression.Store, fi.FullName, fi.Name, "");
                }
            }
        }
    }
}