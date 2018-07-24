using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.AccordionListView
{
    public partial class AccordionPage : ContentPage
    {
        AccordionViewModel viewModel;
        public AccordionPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new AccordionViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView listView = sender as ListView;
            listView.SelectedItem = null;
        }

        async void Handle_Tapped(object sender, EventArgs e)
        {
            Image image = sender as Image;
            await image.RotateTo(180);
            Grid grid = image.Parent as Grid;
            Label label = grid.Children[0] as Label;
            viewModel.ShowCities(label.Text);
        }
    }
}
