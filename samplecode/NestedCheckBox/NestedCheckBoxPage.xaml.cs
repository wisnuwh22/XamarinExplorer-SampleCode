using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.NestedCheckBox
{
    public partial class NestedCheckBoxPage : ContentPage
    {
        NestedCheckBoxViewModel viewModel;
        public NestedCheckBoxPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new NestedCheckBoxViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
