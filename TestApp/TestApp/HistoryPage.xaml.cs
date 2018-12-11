using System;
using System.Collections.Generic;
using SQLite;
using TestApp.Modal;
using Xamarin.Forms;
using System.Linq;
namespace TestApp
{

    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();



            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {


                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();
                postListView.ItemsSource = posts;
               
            }

    }
    }
}