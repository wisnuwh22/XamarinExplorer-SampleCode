using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public partial class BreakfastSandwich : CoolContentPage
    {
        public BreakfastSandwich()
        {
            InitializeComponent();
            if (EnableBackButtonOverride)
            {
                this.CustomBackButtonAction = () =>
                {
                    Application.Current.MainPage = new BreakfastPage();
                };
            }
        }
    }
}
