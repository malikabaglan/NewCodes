using System;
using Maps.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Maps.CustomEntry), typeof(CustomEntry_Ios))]

namespace Maps.iOS
{
    public class CustomEntry_Ios:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
            Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}

