using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataPassing
{
    public partial class MyInformationPage : ContentPage
    {
        public MyInformationPage()
        {
            InitializeComponent();
        }
            async void Handle_Clicked(object sender, System.EventArgs e)
            {
                var mySecondPage = new MyWelcomePage();
                mySecondPage.mySecondPageTitle = "Get to Know Roderick";

                MyInformation myInfo = new MyInformation();
                myInfo.ProfileImage = "Status-Avaibale for Adoption";
                myInfo.FirstName = "Age-2 Years ";
                myInfo.SecondName = "My Second Name";
            myInfo.Introduction = "Hello it is Roderick!!!";
            myInfo.Breed = " Breed-Domestic Medium Hair";
            myInfo.Gender = " Gender-Male";
            myInfo.Weight = " Weight-9.75lbs";
            myInfo.Location = "Location-Lincoln Park Adoption Center";

                mySecondPage.myProfile = myInfo;

                await Navigation.PushAsync(mySecondPage);
            }
        }
    }
