using Cade.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cade.MacOS.Services.MacosFileSystemService))]
namespace Cade.MacOS.Services
{
    public class MacosFileSystemService : IFileSystemService
    {
        public void OpenDirectory()
        {
            throw new System.NotImplementedException("Not Implemented for MacOS yet");
        }
    }
}