﻿using System.Collections.Generic;
using samplecode.AccordionListView;
using samplecode.AirbnbLottie;
using samplecode.CheckBoxRadioButton;
using samplecode.CustomPickerFolder;
using samplecode.GridMenu;
using samplecode.HorizontalListView;
using samplecode.InputForm;
using samplecode.NestedCheckBox;
using samplecode.SQLiteORM;
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
                "Nested CheckBox",
                "Horizontal ListView",
                "SQLite ORM",
                "Airbnb Lottie",
                "Grid Menu"
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
            else if (menu == "Horizontal ListView")
                await Navigation.PushAsync(new NavigationPage(new HorizontalPage()));
            else if (menu == "SQLite ORM")
                await Navigation.PushAsync(new NavigationPage(new DepartmentPage()));
            else if (menu == "Airbnb Lottie")
                await Navigation.PushAsync(new NavigationPage(new LottieAnimationPage()));
            else if(menu == "Grid Menu")
                await Navigation.PushAsync(new NavigationPage(new BreakfastPage()));

        }
    }
}
