using Xamarin.Forms;

namespace samplecode.NestedCheckBox
{
    public partial class ChildrenCheckBox : ContentView
    {
        public ChildrenCheckBox()
        {
            InitializeComponent();
        }

        public static BindableProperty IconSourceProperty =
            BindableProperty.Create(nameof(IconSource), typeof(string), typeof(ChildrenCheckBox), null, BindingMode.TwoWay);

        public string IconSource
        {
            get => (string)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }

        public static BindableProperty MenuTitleProperty =
            BindableProperty.Create(nameof(MenuTitle), typeof(string), typeof(ChildrenCheckBox), null, BindingMode.TwoWay);

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }
    }
}
