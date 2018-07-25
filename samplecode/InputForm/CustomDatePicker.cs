using System;
using Xamarin.Forms;

namespace samplecode.InputForm
{
    public class CustomDatePicker : DatePicker
    {
        public static BindableProperty TextSizeProperty =
            BindableProperty.Create(nameof(TextSize), typeof(int), typeof(CustomDatePicker), 16, BindingMode.TwoWay);

        public int TextSize
        {
            get => (int)GetValue(TextSizeProperty);
            set => SetValue(TextSizeProperty, value);
        }

    }
}
