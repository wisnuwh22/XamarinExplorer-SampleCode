using System;
using Android.Content;
using samplecode.Droid.CustomRenderers;
using samplecode.InputForm;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace samplecode.Droid.CustomRenderers
{
    public class CustomTimePickerRenderer: TimePickerRenderer
    {
        public CustomTimePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customTimePicker = e.NewElement as CustomTimePicker;
                Control.TextSize *= (customTimePicker.TextSize * 0.01f);
            }
        }
    }
}
