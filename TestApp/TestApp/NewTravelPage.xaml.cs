using System;
using System.Collections.Generic;
using System.Linq;
using Plugin.Geolocator;
using SQLite;
using TestApp.Modal;

using Xamarin.Forms;

namespace TestApp
{
    public partial class NewTravelPage : ContentPage
    {
        Post post;

        public NewTravelPage()
        {
            InitializeComponent();
            post = new Post();
            cointainerStacklayout.BindingContext = post;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();
            var venues = await Venue.GetVenues(position.Latitude, position.Longitude);
            venueListView.ItemsSource = venues;
        }



        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {

                var selectedVenue = venueListView.SelectedItem as Venue;
                var firstCategory = selectedVenue.categories.FirstOrDefault();
           
          
                 
                    post.CategoryId = firstCategory.id;
                post.CategoryName = firstCategory.name;
                post.Address = selectedVenue.location.address;
                post.Distance = selectedVenue.location.distance;
                post.Longitude = selectedVenue.location.lng;
                post.Latitude = selectedVenue.location.lat;
                post.VenueName = selectedVenue.name;
                post.UserId = App.user.Id;

             
          
                //using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                //{

                //    conn.CreateTable<Post>();

                //    int rows = conn.Insert(post);

                //    if (rows > 0)
                //        DisplayAlert("Success", "Experience succesfully inserted", "Cancel");
                //    else
                //        DisplayAlert("Failure", "Experience succesfully inserted", "Cancel");

                //}

                 Post.Insert(post);
                await DisplayAlert("Success", "Experience succesfully inserted", "Cancel");

            }
   catch(NullReferenceException nre)
            {
                await DisplayAlert("Failure", "Experience succesfully inserted", "Cancel");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Failure", "Experience failed to be  inserted", "Cancel");
            }
        }
       
    }
}
