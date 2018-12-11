using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class ControlersPage : ContentPage
    {


        public ControlersPage()
        {
            InitializeComponent();
            action.IsEnabled = false;


        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //label.Text = entity.Text;
            string username = entity.Text;
            label.Text = " Hello " +  username;

        }
        async   void OnTapGestureRecognizerTapped(object sender,System.EventArgs e )
        {
            await DisplayAlert("Alert", "Error message ", "Cancel");
            action.IsEnabled = true;
            
        }

    }
}
