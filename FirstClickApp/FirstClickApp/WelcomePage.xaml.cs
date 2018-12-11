using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class WelcomePage : ContentPage
    {
        async  void Handle_Clicked(object sender, System.EventArgs e)
        {
           // await  Navigation.PushAsync(new IntroductionPage());
            await Navigation.PushModalAsync(new IntroductionPage());
        }

        public WelcomePage()
        {
            InitializeComponent();
        }
    }
}
