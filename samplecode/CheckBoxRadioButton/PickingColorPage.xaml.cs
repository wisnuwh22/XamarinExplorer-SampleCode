using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.CheckBoxRadioButton
{
    public partial class PickingColorPage : ContentPage
    {
        PickingColorViewModel viewModel;
        public PickingColorPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PickingColorViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
