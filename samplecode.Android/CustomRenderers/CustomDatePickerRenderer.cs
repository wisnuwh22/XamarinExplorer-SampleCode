using System;
using Android.Content;
using samplecode.Droid.CustomRenderers;
using samplecode.InputForm;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace samplecode.Droid.CustomRenderers
{
    public class CustomDatePickerRenderer: DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customDatePicker = e.NewElement as CustomDatePicker;
                Control.TextSize *= (customDatePicker.TextSize * 0.01f);
            }
        }
    }
}
