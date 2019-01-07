using System;
using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public class CoolContentPage : ContentPage
    {
        public Action CustomBackButtonAction { get; set; }

        public static readonly BindableProperty EnableBackButtonOverrideProperty =
               BindableProperty.Create(nameof(EnableBackButtonOverride), typeof(bool), typeof(CoolContentPage), false);

        /// <summary>
        /// Gets or Sets Custom Back button overriding state
        /// </summary>
        public bool EnableBackButtonOverride
        {
            get
            {
                return (bool)GetValue(EnableBackButtonOverrideProperty);
            }
            set
            {
                SetValue(EnableBackButtonOverrideProperty, value);
            }
        }
    }
}
