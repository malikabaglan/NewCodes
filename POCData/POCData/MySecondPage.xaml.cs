using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCData
{
    public partial class MySecondPage : ContentPage
    {
        //public string mySecondPageTitle;
        //public MyProfile myProfile;

        public MySecondPage(string myPageTitle)
        {
            InitializeComponent();

            this.Title = myPageTitle;
            lbl.Text = myPageTitle;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            /*Console.WriteLine("TITLE : {0}", mySecondPageTitle);
            this.Title = mySecondPageTitle;

            Console.WriteLine("IMG : {0}", myProfile.ProfileImage);
            Console.WriteLine("NAMEF : {0}", myProfile.FirstName);
            Console.WriteLine("NAMES : {0}", myProfile.SecondName);

            lbl.Text = myProfile.FirstName;*/

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            MessagingCenter.Send<MySecondPage, string> (this, "MYFP", "YES IT IS MY 1st PAGE");
            await Navigation.PopAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
