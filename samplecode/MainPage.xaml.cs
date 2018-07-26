using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using samplecode.AccordionListView;
using samplecode.CheckBoxRadioButton;
using samplecode.CustomPickerFolder;
using samplecode.InputForm;
using samplecode.NestedCheckBox;
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
                "Custom Picker",
                "Input Form",
                "CheckBox & RadioButton",
                "Nested CheckBox"
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
            else if (menu == "Custom Picker")
                await Navigation.PushAsync(new NavigationPage(new CustomPickerPage()));
            else if (menu == "Input Form")
                await Navigation.PushAsync(new NavigationPage(new InputFormPage()));
            else if (menu == "CheckBox & RadioButton")
                await Navigation.PushAsync(new NavigationPage(new PickingColorPage()));
            else if (menu == "Nested CheckBox")
                await Navigation.PushAsync(new NavigationPage(new NestedCheckBoxPage()));
        }
    }
}
