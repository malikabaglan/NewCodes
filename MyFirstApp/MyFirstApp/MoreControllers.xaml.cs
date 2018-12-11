using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MoreControllers : ContentPage
    {
        public MoreControllers()
        {
            InitializeComponent();
            //picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

        }
       
void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker_ = (Picker)sender;
            int selectedIndex = picker_.SelectedIndex;
        }

    }
}
