using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ContactMethodsPage : ContentPage
    {
        public ContactMethodsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "Sms"
            };
        }

        public ListView ContactMathods { get { return listView; } }
    }
}