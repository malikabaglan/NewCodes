using System;
using System.Collections.Generic;
using TestApp.ViewModal;
using Xamarin.Forms;

namespace TestApp
{
    public partial class HomePage : TabbedPage
    {
        HomeVM viewModal;
        public HomePage()
        {
   
            InitializeComponent();
            viewModal = new HomeVM();
            BindingContext = viewModal;
            //comm
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}
