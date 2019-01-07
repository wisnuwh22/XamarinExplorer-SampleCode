using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public partial class BreakfastPage : ContentPage
    {
        public BreakfastPage()
        {
            InitializeComponent();
            BindingContext = new BreakfastViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
