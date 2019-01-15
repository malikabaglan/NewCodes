using System;
using System.Collections.Generic;
using System.Linq;
using TestApp.Modal;
using Xamarin.Forms;

namespace TestApp
{
    public partial class ButtonPage : ContentPage
    {
        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        public ButtonPage()
        {
            InitializeComponent();

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            bool canLogin = await User.Login(emailEntry.Text, passwordEntry.Text);
            if (canLogin)
            {
                await Navigation.PushAsync(new HomePage());
           }


            else
                await DisplayAlert("Error", "Try again", "Ok");
            }
        }
    }

