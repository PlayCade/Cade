using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Cade.Annotations;
using Cade.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Cade.ViewModels
{
    public class CollectionPageViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged = null!;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command PlayGameCommand { get; protected set; }

        public CollectionPageViewModel()
        {
            PlayGameCommand = new Command(async () =>
            {
                DependencyService.Get<IFileSystemService>().GetFile();
            });
        }
    }
}