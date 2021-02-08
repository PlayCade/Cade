using Cade.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cade.Android.Services.AndroidFileSystemService))]
namespace Cade.Android.Services
{
    public class AndroidFileSystemService : IFileSystemService
    {
        public void OpenDirectory()
        {
            throw new System.NotImplementedException("Not implemented on Android yet");
        }
    }
}