using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace samplecode.CheckBoxRadioButton
{
    public partial class BindableCheckBox : ContentView
    {
        public BindableCheckBox()
        {
            InitializeComponent();
        }

        public static BindableProperty IconSourceProperty =
            BindableProperty.Create(nameof(IconSource), typeof(string), typeof(BindableCheckBox), null, BindingMode.TwoWay);

        public string IconSource
        {
            get => (string)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }

        public static BindableProperty MenuTitleProperty =
            BindableProperty.Create(nameof(MenuTitle), typeof(string), typeof(BindableCheckBox), null, BindingMode.TwoWay);

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }

        public static BindableProperty TitleColorProperty =
            BindableProperty.Create(nameof(TitleColor), typeof(Color), typeof(BindableCheckBox), Color.Transparent, BindingMode.TwoWay);

        public Color TitleColor
        {
            get => (Color)GetValue(TitleColorProperty);
            set => SetValue(MenuTitleProperty, value);
        }
    }
}
