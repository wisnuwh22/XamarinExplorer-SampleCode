using System;
using Android.Content;
using samplecode.CustomPickerFolder;
using samplecode.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace samplecode.Droid.CustomRenderers
{
    public class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || e.NewElement != null)
            {
                var customPicker = e.NewElement as CustomPicker;
                Control.TextSize *= (customPicker.TextSize * 0.01f);
                Control.SetHintTextColor(Android.Graphics.Color.ParseColor(customPicker.PlaceholderColor));
            }
        }
    }
}
