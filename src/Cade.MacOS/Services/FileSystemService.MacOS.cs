using System.Diagnostics;
using System.IO;
using AppKit;
using Cade.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cade.MacOS.Services.FileSystemService_MacOS))]
namespace Cade.MacOS.Services
{
    public class FileSystemService_MacOS : IFileSystemService
    {
        public FileSystemService_MacOS()
        {
        }
        
        public void OpenDirectory()
        {
            throw new System.NotImplementedException("Not Implemented for MacOS yet");
        }

        public void GetFile()
        {
            var dialog = NSOpenPanel.OpenPanel;
            dialog.CanChooseFiles = true;
            dialog.CanChooseDirectories = false;
            dialog.AllowedFileTypes = new string[] { "png" };

            if (dialog.RunModal() != 1) return;
            // Nab the first file
            var url = dialog.Urls [0];

            Debug.WriteLine(url.Path);



        }
    }
}