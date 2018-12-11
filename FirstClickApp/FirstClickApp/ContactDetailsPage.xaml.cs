using System;
using System.Collections.Generic;
using FirstClickApp.Models;
using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(Contact contact)
        {

            if (contact == null)
                throw new ArgumentNullException();
            BindingContext = contact; 
            InitializeComponent();
        }
    }
}
