using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class NewControllers : ContentPage
    {
        public NewControllers()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognizerTapped (object Sender,EventArgs eventArgs)
        {
            DisplayAlert("Alert", "imageTap", "ok");
        }

    }
}
