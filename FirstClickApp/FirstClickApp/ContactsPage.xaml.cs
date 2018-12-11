using System;
using System.Collections.Generic;
using FirstClickApp.Models;
using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ContactsPage : MasterDetailPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

         
           
         var contact=   e.SelectedItem as Contact;
            Detail = new  NavigationPage(new ContactDetailsPage(contact));
            IsPresented = false;//isMasterPresented 
          
        }

        public ContactsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Contact>
           {
          new Contact {Name="Malika" ,ImageUrl="https://www.gettyimages.com/gi-resources/images/Embed/new/embed2.jpg"},
          new Contact {Name="Chyngyz" ,ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhy3VM7fvGZtT7Y7UrBp7s807MuCO47WfMo50o-sspU5rIYBEI", Status=" Hey,let's talk!"}

             };

        }
    }
}
