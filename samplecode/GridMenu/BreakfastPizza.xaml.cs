using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public partial class BreakfastPizza : CoolContentPage
    {
        public BreakfastPizza()
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
