using System;
using POCCustom.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IDevice_Ios))]
namespace POCCustom.iOS
{

public class IDevice_Ios :IDevice
{
    public string GetDevice(string DeviceId)
    {

            var iosId = UIKit.UIDevice.CurrentDevice.IdentifierForVendor.ToString();

 

            return DeviceId;
}
}
}