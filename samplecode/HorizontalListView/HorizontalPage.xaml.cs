using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.HorizontalListView
{
    public partial class HorizontalPage : ContentPage
    {
        HorizontalViewModel viewModel;
        public HorizontalPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HorizontalViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

            MessagingCenter.Subscribe<HorizontalViewModel, HorizontalItem>(this, "ItemSelected", (obj, item) =>
            {
                DisplayAlert("Alert", "You've choosen Item " + item.Title, "cancel");
            });
        }
    }
}
