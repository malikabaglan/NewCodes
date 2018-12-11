using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ToolBarPage : ContentPage
    {
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "ok");
        }

        public ToolBarPage()
        {
            InitializeComponent();
        }
    }
}
