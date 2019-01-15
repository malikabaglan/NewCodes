using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POCCustom
{
    public partial class MainPage : ContentPage
    {
        void CameraB_Clicked(object sender, System.EventArgs e)
        {
            string cameraTypeString = string.Empty;
            cameraTypeString = DependencyService.Get<IHiCamera>().clickMe("DualCamera");
            Console.WriteLine("{0}",cameraTypeString);
        }

        public MainPage()
        {
            InitializeComponent();
        }

        void Device_Clicked(object sender, System.EventArgs e)
        {
         
        }
    }
}
