using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.InputForm
{
    public partial class InputFormPage : ContentPage
    {
        InputFormViewModel viewModel;
        public InputFormPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new InputFormViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (viewModel.EditorPlaceholder == viewModel.Desription)
                viewModel.Desription = string.Empty;
            Navigation.PushAsync(new DisplayFormPage(viewModel));
        }
    }
}
