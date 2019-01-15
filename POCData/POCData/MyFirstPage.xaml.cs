using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POCData
{
    public partial class MyFirstPage : ContentPage
    {
        public MyFirstPage()
        {
            InitializeComponent();

            this.Title = "This is first page";


            MessagingCenter.Subscribe<MySecondPage, string>(this, "MYFP", (sender, results) => 
            {
                Console.WriteLine("TITLE : {0}", results);
                this.Title = results;
            });
        }

 async void Handle_Clicked(object sender, System.EventArgs e)
        {
            /*var mySecondPage = new MySecondPage();
            mySecondPage.mySecondPageTitle = "This is second page";

            MyProfile myProfile = new MyProfile();
            myProfile.ProfileImage = "My Profile Image URL";
            myProfile.FirstName = "My First Name";
            myProfile.SecondName = "My Second Name";

            mySecondPage.myProfile = myProfile;*/

            await Navigation.PushAsync(new MySecondPage("This is second page"));

        }
    }
}
