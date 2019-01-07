using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public partial class BreakfastBurger : CoolContentPage
    {
        public BreakfastBurger()
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
