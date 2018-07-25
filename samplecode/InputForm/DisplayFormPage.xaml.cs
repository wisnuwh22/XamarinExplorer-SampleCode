using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.InputForm
{
    public partial class DisplayFormPage : ContentPage
    {
        public DisplayFormPage(InputFormViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
