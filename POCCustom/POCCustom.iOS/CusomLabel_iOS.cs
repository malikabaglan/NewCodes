using System;
using POCCustom;
using POCCustom.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CusomLabel_iOS))]
namespace POCCustom.iOS
{
    public class CusomLabel_iOS : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.TextAlignment = UITextAlignment.Right;

            }
        }
    }
}
