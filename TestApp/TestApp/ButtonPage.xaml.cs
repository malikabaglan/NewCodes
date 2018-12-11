using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class ButtonPage : ContentPage
    {

        public ButtonPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           bool  isEmailEmpty=string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty  || isPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
