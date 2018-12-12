using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace samplecode.AirbnbLottie
{
    public partial class LottieAnimationPage : ContentPage
    {
        LottieAnimationViewModel viewModel;
        public LottieAnimationPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel = new LottieAnimationViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

            MessagingCenter.Subscribe<LottieAnimationViewModel>(this, "play", (obj) =>
            {
                AnimationView.Play();
            });
        }

       
    }
}
