using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataPassing
{
    public partial class MyWelcomePage : ContentPage
    {
        public string mySecondPageTitle;
        public  MyInformation myProfile;


        public MyWelcomePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

           
            this.Title = mySecondPageTitle;

            introduction.Text = myProfile.Introduction;
            lbl.Text = myProfile.FirstName;
            lastName.Text = myProfile.ProfileImage;
            breed.Text = myProfile.Breed;
            gender.Text = myProfile.Gender;
            weight.Text = myProfile.Weight;
            location.Text = myProfile.Location;

            gender.TextDecorations = TextDecorations.Strikethrough;
        }

       async  void Handle_Clicked(object sender, System.EventArgs e)
        {
          await Navigation.PushAsync(new MeetKittyPage());

           await DisplayAlert("Thank you!!", "Please Sumbit Your Information in next Page", "OK");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}

