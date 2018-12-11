using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class IntroductionPage : ContentPage
    {
        async  void Handle_Clicked(object sender, System.EventArgs e)
        {
            //await Navigation.PopAsync();
            await Navigation.PopModalAsync();
        }

        public IntroductionPage()
        {
            InitializeComponent();
        }
    }
}
