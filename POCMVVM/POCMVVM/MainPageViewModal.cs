using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
//mvvm concept to communicate 
namespace POCMVVM
{
    public class MainPageViewModal: INotifyPropertyChanged
    {
        public ICommand BtnClick { get; set; }
        string _LblText = "This is 'MVVM'";         public string Text         {             get => _LblText;             set             {                 if (string.Equals(_LblText, value))                     return;                  _LblText = value;                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));             }         }

        public event PropertyChangedEventHandler PropertyChanged;         public void OnPropertyChanged([CallerMemberName] string name = "")         {             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));         } 
        public MainPageViewModal()
        {
            BtnClick = new Command(OnClicked);
        }
        void OnClicked()
        {
            Text = "xamarin forms ";
        }
    }
}
