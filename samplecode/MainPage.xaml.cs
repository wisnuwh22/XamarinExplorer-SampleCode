using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using samplecode.AccordionListView;
using Xamarin.Forms;

namespace samplecode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new List<string>()
            {
                "Accordion ListView",
                "Custom Picker"
            };
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as string;
            if (menu == "Accordion ListView")
                await Navigation.PushAsync(new NavigationPage(new AccordionPage()));
        }
    }
}
