using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FirstClickApp.Models;
using Xamarin.Forms;

namespace FirstClickApp
{
    public partial class ListViewPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
           // var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
           var menuItem = sender as MenuItem;
           var contact= menuItem.CommandParameter as Contact;
           DisplayAlert("Call", contact.Name, "OK");

        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            //listView.ItemTapped = null;
         var  contact=   e.Item as Contact;
           DisplayAlert("Tapped", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }       

        public ListViewPage()
        {
            InitializeComponent();
            _contacts= new ObservableCollection<Contact>{
                new Contact {Name="Malika" ,ImageUrl="https://www.gettyimages.com/gi-resources/images/Embed/new/embed2.jpg"},


                new Contact {Name="Chyngyz" ,ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhy3VM7fvGZtT7Y7UrBp7s807MuCO47WfMo50o-sspU5rIYBEI", Status=" Hey,let's talk!"}

            };
            listView.ItemsSource = _contacts;

        }

        }
    }




    /*void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    public ListViewPage()
    {
        InitializeComponent();

        listView.ItemsSource = new List<ContactGroup>
        {
            new ContactGroup("M" ,"M")
            {
                 new Contact {Name="Malika" ,ImageUrl="https://www.gettyimages.com/gi-resources/images/Embed/new/embed2.jpg"}
            },
            new ContactGroup("C" ,"C")
            {


            new Contact {Name="Chyngyz" ,ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhy3VM7fvGZtT7Y7UrBp7s807MuCO47WfMo50o-sspU5rIYBEI", Status=" Hey,let's talk!"}
        }
            };


    }
}
}*/


/*void Call_Clicked(object sender, System.EventArgs e)
{
    var menuItem = sender as MenuItem;
    var contact = menuItem.CommandParameter as Contact;
    DisplayAlert("Call", contact.Name, "OK");

}

void Delete_Clicked(object sender, System.EventArgs e)
{
    throw new NotImplementedException();
}
}
}*/
