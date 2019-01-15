using System;
using TestApp.ViewModal.Commands;

namespace TestApp.ViewModal
{
    public class HomeVM
    {
        public NavigationCommands NavCommand { get; set; }

            public HomeVM()
        {
            NavCommand = new NavigationCommands(this);

        }
        public async  void Navigate()
        {
           await App.Current.MainPage.Navigation.PushAsync(new NewTravelPage());
        }
    }
}

