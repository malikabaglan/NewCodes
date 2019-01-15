using System;
using POCCustom.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(IDevice_Droid))]
namespace POCCustom.Droid
{
    public class IDevice_Droid : IDevice
    {
        public string GetDevice(string DeviceId)
        {

            var DroidId = Android.Provider.Settings.Secure.GetString(Forms.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);


    return DroidId;
    }

    }
}
