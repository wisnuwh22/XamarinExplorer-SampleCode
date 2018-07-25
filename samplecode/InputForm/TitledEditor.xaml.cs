using System;
using Xamarin.Forms;

namespace samplecode.InputForm
{
    public partial class TitledEditor : ContentView
    {
        public TitledEditor()
        {
            InitializeComponent();

            EditorContent.BindingContext = this;
            LabelTitle.BindingContext = this;
        }

        public static BindableProperty PlaceholderProperty =
            BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(TitledEditor), string.Empty, BindingMode.TwoWay);

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static BindableProperty PlaceholderColorProperty =
            BindableProperty.Create(nameof(PlaceholderColor), typeof(string), typeof(TitledEditor), "#cccccc", BindingMode.TwoWay);

        public string PlaceholderColor
        {
            get { return (string)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }

        public static BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(TitledEditor), string.Empty, BindingMode.TwoWay);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(int), typeof(TitledEditor), 16, BindingMode.TwoWay);

        public int FontSize
        {
            get => (int)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public static BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(TitledEditor), Color.Default, BindingMode.TwoWay);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }


        void Handle_ContainerFocused(object sender, FocusEventArgs e)
        {
            EditorContent.Focus();
        }

        void Handle_BindingContextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = Placeholder;
                LabelTitle.IsVisible = false;
                TextColor = Color.FromHex(PlaceholderColor);
            }
            else
            {
                LabelTitle.IsVisible = true;
                TextColor = Color.Default;
            }
        }

        void Handle_Focused(object sender, FocusEventArgs e)
        {
            LabelTitle.IsVisible = true;

            if (Placeholder == Text)
            {
                Text = string.Empty;
            }
        }

        void Handle_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                Text = Placeholder;
                LabelTitle.IsVisible = false;
                TextColor = Color.FromHex(PlaceholderColor);
            }
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                LabelTitle.IsVisible = true;
                TextColor = Color.FromHex(PlaceholderColor);
            }
            else
            {
                if (Text != Placeholder)
                {
                    LabelTitle.IsVisible = true;
                    EditorContent.TextColor = Color.Default;
                }
                else
                {
                    EditorContent.TextColor = Color.FromHex(PlaceholderColor);
                }
            }
        }
    }
}
