using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailPractice
{
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MyPage1());
            IsPresented = false;
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new MyPage1());
            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new MyPage2());
            IsPresented = false;
        }
    }
}
