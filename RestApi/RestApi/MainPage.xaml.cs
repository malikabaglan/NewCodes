using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //List<TechItem> techItems = await App.TechManager.GetAsyncData();
            //TechList.ItemsSource = techItems;

            //TechItem techItem = techItems[3];
        

           // Console.WriteLine("NAME : {0}", techItem.Name);
          //  Console.WriteLine("Language : {0}", techItem.Language);

            /*RestApi.Text = techItem.Language;
            RestApi.Text = techItem.Name;
            RestApi.Text = techItem.Rank.ToString();*/
          
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //   List<TechItem> techItems = await App.TechManager.GetAsyncData();
            List<TechItem> techItems = await App.TechManager.PostAsyncData();

            //List<TechItem> updatedItem = new List<TechItem>();
            //updatedItem.Add(techItems[0]);
            //updatedItem.Add(techItems[1]);

            TechList.ItemsSource = techItems;
        }
    }
}
