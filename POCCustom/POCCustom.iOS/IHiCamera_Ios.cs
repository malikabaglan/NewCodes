using System;
using POCCustom.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IHiCamera_Ios))]
namespace POCCustom.iOS
{
    public class IHiCamera_Ios : IHiCamera
    {
        public string clickMe(string CameraType)
        {
            return CameraType;
        }
        
    }
}

