using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace samplecode.CheckBoxRadioButton
{
    public partial class BindableRadioButton : ContentView
    {
        public BindableRadioButton()
        {
            InitializeComponent();
        }

        public static BindableProperty IconSourceProperty =
            BindableProperty.Create(nameof(IconSource), typeof(string), typeof(BindableRadioButton), null, BindingMode.TwoWay);

        public string IconSource
        {
            get => (string)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }

        public static BindableProperty MenuTitleProperty =
            BindableProperty.Create(nameof(MenuTitle), typeof(string), typeof(BindableRadioButton), null, BindingMode.TwoWay);

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }
    }
}
