using Xamarin.Forms;

namespace samplecode.NestedCheckBox
{
    public partial class ParentCheckBox : ContentView
    {
        public ParentCheckBox()
        {
            InitializeComponent();
        }

        public static BindableProperty IconSourceProperty =
            BindableProperty.Create(nameof(IconSource), typeof(string), typeof(ParentCheckBox), null, BindingMode.TwoWay);

        public string IconSource
        {
            get => (string)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }

        public static BindableProperty MenuTitleProperty =
            BindableProperty.Create(nameof(MenuTitle), typeof(string), typeof(ParentCheckBox), null, BindingMode.TwoWay);

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }
    }
}
