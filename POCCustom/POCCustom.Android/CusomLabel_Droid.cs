using System;
using Android.Content;
using POCCustom;
using POCCustom.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CusomLabel_Droid))]
namespace POCCustom.Droid
{
    public class CusomLabel_Droid : LabelRenderer
    {
        public CusomLabel_Droid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                Control.TextAlignment = Android.Views.TextAlignment.TextStart;
            }
        }
    }

}



