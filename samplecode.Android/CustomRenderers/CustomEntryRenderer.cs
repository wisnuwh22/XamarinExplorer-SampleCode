using System;
using Android.Content;
using samplecode.Droid.CustomRenderers;
using samplecode.InputForm;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace samplecode.Droid.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customEntry = e.NewElement as CustomEntry;
                Control.SetHintTextColor(Android.Graphics.Color.ParseColor(customEntry.TitleColor));
            }

        }
    }
}
