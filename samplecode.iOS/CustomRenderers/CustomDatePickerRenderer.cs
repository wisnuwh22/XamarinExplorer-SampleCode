using System;
using Foundation;
using samplecode.InputForm;
using samplecode.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace samplecode.iOS.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customDatePicker = e.NewElement as CustomDatePicker;

                float textSize = (float)customDatePicker.TextSize;

                // create font decsriptor
                var label = new UILabel();
                var fontDescriptor = label.Font.FontDescriptor;

                // adjusting font size
                var newDescriptor = fontDescriptor.CreateWithAttributes(new UIFontAttributes()
                {
                    Size = textSize
                });
                UIFont font = UIFont.FromDescriptor(newDescriptor, 0);

                // set attributes
                //var placeholderAttributes = new NSAttributedString(customDatePicker.Date.ToString("dd MMM yyyy"), new UIStringAttributes()
                //{ Font = font });

                //Control.AttributedPlaceholder = placeholderAttributes;


                var textAttributes = new NSAttributedString(customDatePicker.Date.ToString("dd MMM yyyy"), new UIStringAttributes()
                { Font = font });

                Control.AttributedText = textAttributes;

            }
        }
    }
}
