using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Maps
{
    public class ViewModal : INotifyPropertyChanged
    {
        public Command TappedCheckBoxMale { get; private set; }

        public Command TappedCheckBoxFemale { get; private set; }


        public string _CheckBoxMale = "checked.png";
        public string CheckBoxMale
        {
            get
            {
                return _CheckBoxMale;
            }
            set
            {
                if (_CheckBoxMale !=value)
                    
                    {
                    _CheckBoxMale = value;
                    NotifyPropertyChanged("CheckBoxMale");
                }
            }
        }

        public string _CheckBoxFemale = "unchecked.png";
        public string CheckBoxFemale
        {
            get
            {
                return _CheckBoxFemale;
            }
            set
            {
                if (_CheckBoxFemale != value)

                {
                    _CheckBoxFemale = value;
                    NotifyPropertyChanged("CheckBoxFemale");
                }
            }
        }


     public ViewModal()

        {
            TappedCheckBoxMale= new Command (TappedCheckBoxMaleImage);
            TappedCheckBoxFemale = new Command(TappedCheckBoxFemaleImage);
        }

        private void TappedCheckBoxMaleImage()
        {
            CheckBoxMale="checked.png";
            CheckBoxFemale = "unchecked.png";
        }

        private void TappedCheckBoxFemaleImage ()
        {
            CheckBoxMale= "unchecked.png";
            CheckBoxFemale = "checked.png";
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
