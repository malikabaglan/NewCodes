using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class TableViewPage : ContentPage
    {
        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMathods.ItemSelected += (source, args) =>
              {
                  contactMethod.Text = args.SelectedItem.ToString();
                  Navigation.PopAsync();
              };

            Navigation.PushAsync(page);
        }

        public TableViewPage()
        {
            InitializeComponent();
        }
    }
}
