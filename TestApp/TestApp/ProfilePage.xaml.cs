using System;
using System.Collections.Generic;
using SQLite;
using TestApp.Modal;
using Xamarin.Forms;
using System.Linq;

namespace TestApp
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            // {
            var postTable = await Post.Read();
                var categories = (from p in postTable 
                orderby p.CategoryId 
                select p.CategoryName).Distinct().ToList();


              /*  //Dictionary<string,int> categoriesCount= new Dictionary<string, int>();
                foreach(var category in categories)
                {
                    var count = (from post in postTable
                                 where post.CategoryName == category
                                 select post).ToList().Count;

                    var count2 = postTable.Where(p => p.CategoryName == category).ToList().Count;

                    categoriesCount.Add(category,count2);
               
                categoriesListView.ItemsSource = categoriesCount;

                }*/
                postCountLabel.Text = postTable.Count.ToString();
            }

       // }
    }
}
