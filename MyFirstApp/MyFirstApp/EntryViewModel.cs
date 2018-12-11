using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyFirstApp
{
    public class EntryViewModel : INotifyPropertyChanged
    {
        public EntryViewModel() { }
        
        private string _UserNameEntry;
        public string UserNameEntry
        {
            get
            {
                return _UserNameEntry;
            }
            set
            {
                _UserNameEntry = value;
                //Console.WriteLine("U _ NAME : {0}", _UserNameEntry);
                _TextLbl = _UserNameEntry;
            }
        }

        private string _PassWordEntry;
        public string PassWordEntry
        {
            get { return _PassWordEntry; }
            set
            {
                _PassWordEntry = value;
                //Console.WriteLine("PASSWORD : {0}", _PassWordEntry);
                _TextLbl = _PassWordEntry;
            }
        }

        private string _TextLbl;
        public string TextLbl
        {
            get { return _TextLbl; }
            set
            {
                _TextLbl = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
