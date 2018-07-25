using System;
using Foundation;
using samplecode.InputForm;
using samplecode.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace samplecode.iOS.CustomRenderers
{
    public class CustomTimePickerRenderer : TimePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customTimePicker = e.NewElement as CustomTimePicker;


                // get Bindable properties
                float textSize = (float)customTimePicker.TextSize;


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
                var textAttributes = new NSAttributedString(customTimePicker.Time.ToString(), new UIStringAttributes()
                { Font = font });

                Control.AttributedText = textAttributes;

            }
        }
    }
}
