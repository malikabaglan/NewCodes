using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class EntryView : ContentPage
    {
        public EntryView()
        {
            InitializeComponent();
            BindingContext = new EntryViewModel();

            // * which is event - can create a method 
            UserNameT.Unfocused += PressUserNameT;
            PasswordT.Unfocused += PressPassWordT;
        }

        private void PressUserNameT(object sender, FocusEventArgs e)
        {
            //DisplayAlert("UserName", "Tapped UserName T", "Ok");

        }

        private void PressPassWordT(object sender, FocusEventArgs e)
        {
            //DisplayAlert("Password", "Tapped Password T", "Ok");
        }

    }
}
