using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public partial class BreakfastBacon : CoolContentPage
    {
        public BreakfastBacon()
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
