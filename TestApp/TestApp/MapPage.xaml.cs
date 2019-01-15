using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Linq;
using System.Text;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using SQLite;
using TestApp.Modal;

namespace TestApp
{
    public partial class MapPage : ContentPage
    {
        private bool hasLocationPermission = false;
        public MapPage()
        {
            InitializeComponent();
            GetPermissions();
        }

        private async void GetPermissions()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                    {
                        await DisplayAlert("Need yoyur location ", "We need to access your location", "ok");

                    }
                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                    if (results.ContainsKey(Permission.LocationWhenInUse))
                        status = results[Permission.LocationWhenInUse];

                }

                if (status == PermissionStatus.Granted)
                {
                    hasLocationPermission = true;
                    locationMaps.IsShowingUser = true;
                    GetLocation();
                }
                else
                {
                    await DisplayAlert("Location denied ", "You did not give us permission to access location,so we can not show your location", "ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "ok");
            }

        }
        protected override  async void OnAppearing()
        {
            base.OnAppearing();
            if (hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;
                locator.PositionChanged +=Locator_PositionChanged;
               await locator.StartListeningAsync(TimeSpan.Zero,100);
            }
                GetLocation();

        }
        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
          await  CrossGeolocator.Current.StopListeningAsync();
            CrossGeolocator.Current.PositionChanged -= Locator_PositionChanged;
          
            //bad code 
               // var locator = CrossGeolocator.Current;
          //  locator.PositionChanged -= Locator_PositionChanged;
          //  await locator.StopListeningAsync();



          }

        void Locator_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            MoveMap(e.Position);
        }


        private async void GetLocation()
        {
        if (hasLocationPermission)
            {
            var locator = CrossGeolocator.Current;
        var position = await locator.GetPositionAsync();
                MoveMap(position);


    }
}
        private async void MoveMap(Position position)
        {
            var center = new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, 1, 1);
            locationMaps.MoveToRegion(span);


            //using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            //{


            //    conn.CreateTable<Post>();
            //    var posts = conn.Table<Post>().ToList();

            //    DisplayMap(posts);

            //}


            var posts = await Post.Read();

            //    DisplayMap(posts);
        }
        private void DisplayMap(List<Post> posts)
        {
            foreach(var post in posts)
            {
                try
                {
var position = new Xamarin.Forms.Maps.Position(post.Latitude, post.Longitude);
                var pin = new Xamarin.Forms.Maps.Pin()
                {
                    Type=Xamarin.Forms.Maps.PinType.SavedPin,
                    Position=position,
                    Label=post.VenueName,
                    Address=post.Address,
                };
                locationMaps.Pins.Add(pin);
              }
                catch (NullReferenceException nre)
                {

                }
                catch(Exception e)
                {

                }

            }
        }

    }
}






