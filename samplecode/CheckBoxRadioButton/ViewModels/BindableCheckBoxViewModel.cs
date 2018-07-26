using System;
using Xamarin.Forms;

namespace samplecode.CheckBoxRadioButton
{
    public class BindableCheckBoxViewModel : BaseViewModel
    {
        protected bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                SetProperty(ref isEnabled, value);
                UpdateImageSource();
                UpdateTitleColor();
            }
        }

        protected bool isChecked;
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                SetProperty(ref isChecked, value);
                UpdateImageSource();
                UpdateTitleColor();
            }
        }

        protected string menuTitle;
        public String MenuTitle
        {
            get => menuTitle;
            set => SetProperty(ref menuTitle, value);
        }

        protected Color titleColor;
        public Color TitleColor
        {
            get => titleColor;
            set => SetProperty(ref titleColor, value);
        }

        protected string iconSource;
        public string IconSource
        {
            get => iconSource;
            set => SetProperty(ref iconSource, value);
        }

        public Color DefaultTitleColor { get; set; }

        protected void UpdateImageSource()
        {
            if (IsEnabled)
            {
                if (IsChecked)
                {
                    IconSource = "CheckBox.png";
                }
                else
                {
                    IconSource = "CheckBoxEmpty.png";
                }
            }
            else
            {
                IconSource = "CheckBoxEmptyDisable.png";
            }
        }

        protected void UpdateTitleColor()
        {
            if (IsEnabled)
            {
                if (IsChecked)
                {
                    TitleColor = DefaultTitleColor;
                }
                else
                {
                    TitleColor = Color.Black;
                }
            }
            else
            {
                TitleColor = Color.FromHex("#b7b7b7");
            }
        }


        public void SetEnable(bool _isEnable)
        {
            IsEnabled = _isEnable;
        }
    }
}
