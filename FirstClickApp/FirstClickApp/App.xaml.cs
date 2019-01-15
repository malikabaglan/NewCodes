using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FirstClickApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridPage();
            //MainPage = new NavigationPage(new WelcomePage());
            //MainPage = new ContactsPage();
           // MainPage = new MainPage();
            // MainPage = new TypeOfAlerts();
           //MainPage = new NavigationPage(new ToolBarPage());
            //MainPage = new SwitchPage();
            ////MainPage = new NavigationPage(new TableViewPage());
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
