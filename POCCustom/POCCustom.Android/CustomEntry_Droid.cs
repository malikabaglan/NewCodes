using System;
using Android.Content;
using POCCustom;
using POCCustom.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntry_Droid))]
namespace POCCustom.Droid
{
    public class CustomEntry_Droid :EntryRenderer
    {
        public CustomEntry_Droid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
         
            }
        }
    }
}
