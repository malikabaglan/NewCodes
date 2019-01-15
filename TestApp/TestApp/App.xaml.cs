using System;
using Microsoft.WindowsAzure.MobileServices;
using TestApp.Modal;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestApp
{
    public partial class App : Application


    {

        public static string DatabaseLocation = string.Empty;


        public static MobileServiceClient MobileService = new MobileServiceClient("https://malikasapp.azurewebsites.net");


        public static User user = new User();

        public App()
        {



            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new NavigationPage(new ButtonPage());
        }

        public App(string dataBaseLocation)
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new NavigationPage(new ButtonPage());
            DatabaseLocation = dataBaseLocation;
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}