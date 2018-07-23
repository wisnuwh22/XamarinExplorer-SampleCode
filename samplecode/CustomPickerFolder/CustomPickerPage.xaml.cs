using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.CustomPickerFolder
{
    public partial class CustomPickerPage : ContentPage
    {
        public CustomPickerPage()
        {
            InitializeComponent();
            this.BindingContext = new List<string>()
            {
                "Test 1",
                "Test 2",
                "Test 3"
            };
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
