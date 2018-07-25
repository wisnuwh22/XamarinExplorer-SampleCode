using System;
using Xamarin.Forms;

namespace samplecode.InputForm
{
    public class CustomEntry : Entry
    {
        public static BindableProperty TitleColorProperty =
            BindableProperty.Create(nameof(TitleColor), typeof(string), typeof(CustomEditor), "#cccccc", BindingMode.TwoWay);

        public string TitleColor
        {
            get { return (string)GetValue(TitleColorProperty); }
            set { SetValue(TitleColorProperty, value); }
        }
    }
}
