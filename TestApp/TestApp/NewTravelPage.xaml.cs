using System;
using System.Collections.Generic;
using SQLite;
using TestApp.Modal;
using Xamarin.Forms;

namespace TestApp
{
    public partial class NewTravelPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experiencyEntry.Text
            };



            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {

                conn.CreateTable<Post>();

                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("Success", "Experience succesfully inserted", "Cancel");
                else
                    DisplayAlert("Failure", "Experience succesfully inserted", "Cancel");

            }
          
        }

        public NewTravelPage()
        {
            InitializeComponent();
        }
    }
}
