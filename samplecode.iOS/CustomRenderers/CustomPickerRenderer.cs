using System;
using Foundation;
using samplecode.CustomPickerFolder;
using samplecode.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace samplecode.iOS.CustomRenderers
{
    public class CustomPickerRenderer: PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customPicker = e.NewElement as CustomPicker;

                // Placeholder Color
                string placeholderColor = customPicker.PlaceholderColor;
                UIColor color = UIColor.FromRGB(GetRed(placeholderColor), GetGreen(placeholderColor), GetBlue(placeholderColor));

                // Font Size
                var label = new UILabel();
                var originalDescriptor = label.Font.FontDescriptor;
                var newDescriptor = originalDescriptor.CreateWithAttributes(new UIFontAttributes()
                {
                    Size = (float)customPicker.TextSize
                });

                UIFont font = UIFont.FromDescriptor(newDescriptor, 0);
                //font.WithSize((float)customPicker.TextSize);

                var placeholderAttributes = new NSAttributedString(customPicker.Title, new UIStringAttributes()
                { ForegroundColor = color, Font = font });

                Control.AttributedPlaceholder = placeholderAttributes;

            }
        }

        private float GetRed(string color)
        {
            Color c = Color.FromHex(color);
            return (float)c.R;
        }

        private float GetGreen(string color)
        {
            Color c = Color.FromHex(color);
            return (float)c.G;
        }

        private float GetBlue(string color)
        {
            Color c = Color.FromHex(color);
            return (float)c.B;
        }
    }
}
