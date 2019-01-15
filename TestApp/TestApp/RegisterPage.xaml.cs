using System;
using System.Collections.Generic;
using TestApp.Modal;
using Xamarin.Forms;

namespace TestApp
{
    public partial class RegisterPage : ContentPage
    {
        User user;
      async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (passwordEntry.Text==confirmPassword.Text)
            {
               
                User.Register(user);
            }
            else
            {
               await DisplayAlert("Error", "Password don't match", "ok");
            }
        }

        public RegisterPage()
        {
            InitializeComponent();
            user = new User();
            containerStacklayout.BindingContext = user;
        }
    }
}
