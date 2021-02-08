using System;
using System.Diagnostics;
using Cade.Interfaces;
using Foundation;
using UIKit;
using UniformTypeIdentifiers;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cade.iOS.Services.FileSystemService_iOS))]
namespace Cade.iOS.Services
{
    // ReSharper disable once InconsistentNaming
    public class FileSystemService_iOS : IFileSystemService
    {
        private readonly UIViewController? _currentViewController;
        
        public FileSystemService_iOS()
        {
            var window= UIApplication.SharedApplication.KeyWindow;
            _currentViewController = window.RootViewController;
            while (_currentViewController?.PresentedViewController != null)
            {
                _currentViewController = _currentViewController.PresentedViewController;
            }
        }
        
        public void OpenDirectory()
        {
            throw new System.NotImplementedException("Not Implemented for iOS yet");
        }

        public void GetFile()
        {
            string[] allowedUTIs = { UTTypes.Png.ToString() };
            var picker = new UIDocumentPickerViewController(allowedUTIs, UIDocumentPickerMode.Open)
            {
                ShouldShowFileExtensions = true
            };
            picker.WasCancelled += PickerOnWasCancelled;
            picker.DidPickDocumentAtUrls += PickerOnDidPickDocumentAtUrls;

            _currentViewController?.PresentViewController(picker, true, null);
        }

        private void PickerOnDidPickDocumentAtUrls(object sender, UIDocumentPickedAtUrlsEventArgs e)
        {
            Console.WriteLine($"url = {e.Urls[0].AbsoluteString}");  
            
            string filename = e.Urls[0].LastPathComponent;

            var alertController = UIAlertController.Create("import", filename, UIAlertControllerStyle.Alert);  
            var okButton = UIAlertAction.Create("OK", UIAlertActionStyle.Default, (obj) =>  
            {  
                alertController.DismissViewController(true, null);  
            });  
            alertController.AddAction(okButton);  
            _currentViewController.PresentViewController(alertController, true, null);  
        }

        private void PickerOnWasCancelled(object sender, EventArgs e)
        {
            Debug.WriteLine("Picker was Cancelled");
        }
    }
}