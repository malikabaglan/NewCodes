using System;
using POCCustom.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(IHiCamera_Droid))]
namespace POCCustom.Droid
{
    public class IHiCamera_Droid : IHiCamera
    {
        public string clickMe(string CameraType)
        {
            return CameraType;
        }
    }
}
