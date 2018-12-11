using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Maps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

       

        }
        protected async override void OnAppearing()

        {
            base.OnAppearing();
            var geolocator = CrossGeolocator.Current;
            var position = await geolocator.GetPositionAsync(TimeSpan.FromSeconds(10));


            Debug.WriteLine("Position Status: {0}", position.Timestamp);
                        Debug.WriteLine("Position Latitude: {0}", position.Latitude);
                        Debug.WriteLine("Position Longitude: {0}", position.Longitude);
                        

            GoogleMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMiles(1)));
        }

    }
}
