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
            List<TechItem> techItems = await App.TechManager.GetAsyncData();
            TechItem techItem = techItems[0];

            Console.WriteLine("NAME : {0}", techItem.Name);
            Console.WriteLine("Language : {0}", techItem.Language);

            RestApi.Text = techItem.Language;
        }
    }
}
