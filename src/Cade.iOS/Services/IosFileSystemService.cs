using Cade.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cade.iOS.Services.IosFileSystemService))]
namespace Cade.iOS.Services
{
    public class IosFileSystemService : IFileSystemService
    {
        public void OpenDirectory()
        {
            throw new System.NotImplementedException("Not Implemented for iOS yet");
        }
    }
}