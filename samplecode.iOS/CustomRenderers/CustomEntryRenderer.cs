using System;
using Foundation;
using samplecode.InputForm;
using samplecode.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace samplecode.iOS.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var customEntry = e.NewElement as CustomEntry;
                UIColor placeholderColor = GetUIColor(customEntry.TitleColor);

                if(customEntry.Placeholder != null)
                {
                    var placeholderAttributes = new NSAttributedString(customEntry.Placeholder, new UIStringAttributes()
                    { ForegroundColor = placeholderColor });

                    Control.AttributedPlaceholder = placeholderAttributes;
                }
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }

        private UIColor GetUIColor(string color)
        {
            return UIColor.FromRGB(GetRed(color), GetGreen(color), GetBlue(color));
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
