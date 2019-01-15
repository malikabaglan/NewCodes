using System;
using POCCustom;
using POCCustom.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry_IOS))]
namespace POCCustom.iOS
{
    public class CustomEntry_IOS:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
                //Control.TextColor = UIColor.DarkTextColor; to change textColor
           

            }
        }
    }
}
