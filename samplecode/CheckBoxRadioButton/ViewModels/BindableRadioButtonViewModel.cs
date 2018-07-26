using System;
namespace samplecode.CheckBoxRadioButton
{
    public class BindableRadioButtonViewModel : BaseViewModel
    {
        protected bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                SetProperty(ref isSelected, value);
                UpdateIconSource();
            }
        }
        protected string menuTitle;
        public string MenuTitle
        {
            get => menuTitle;
            set => SetProperty(ref menuTitle, value);
        }

        protected string iconSource;
        public string IconSource
        {
            get => iconSource;
            set => SetProperty(ref iconSource, value);
        }

        protected bool enableProperty;
        public bool EnableProperty
        {
            get => enableProperty;
            set => SetProperty(ref enableProperty, value);
        }

        protected void UpdateIconSource()
        {
            if (IsSelected)
                IconSource = "RadioButtonChecked.png";
            else
                IconSource = "RadioButtonUnchecked.png";
        }

    }
}
