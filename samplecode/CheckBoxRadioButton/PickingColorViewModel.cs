using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace samplecode.CheckBoxRadioButton
{
    public class PickingColorViewModel : BaseViewModel
    {
        protected ObservableCollection<BindableRadioButtonViewModel> listRadioButton;
        public ObservableCollection<BindableRadioButtonViewModel> ListRadioButton
        {
            get => listRadioButton;
            set => SetProperty(ref listRadioButton, value);
        }

        protected BindableRadioButtonViewModel selectedRadioButton;
        public BindableRadioButtonViewModel SelectedRadioButton
        {
            get => selectedRadioButton;
            set => SetProperty(ref selectedRadioButton, value);
        }

        public ICommand RadioButtonTappedCommand { get; set; }

        protected ObservableCollection<BindableCheckBoxViewModel> listCheckBox;
        public ObservableCollection<BindableCheckBoxViewModel> ListCheckBox
        {
            get => listCheckBox;
            set => SetProperty(ref listCheckBox, value);
        }

        protected BindableCheckBoxViewModel selectedCheckBox;
        public BindableCheckBoxViewModel SelectedCheckBox
        {
            get => selectedCheckBox;
            set => SetProperty(ref selectedCheckBox, value);
        }

        public ICommand CheckBoxTappedCommand { get; set; }

        public PickingColorViewModel()
        {
            ListRadioButton = new ObservableCollection<BindableRadioButtonViewModel>()
            {
                new BindableRadioButtonViewModel(){ IsSelected = true, EnableProperty = true, MenuTitle = "Enable" },
                new BindableRadioButtonViewModel(){ IsSelected = false, EnableProperty = false, MenuTitle = "Disable" }
            };

            ListCheckBox = new ObservableCollection<BindableCheckBoxViewModel>()
            {
                new BindableCheckBoxViewModel() { IsEnabled = true, IsChecked = false, MenuTitle ="Cyan", DefaultTitleColor = Color.Cyan },
                new BindableCheckBoxViewModel() { IsEnabled = true, IsChecked = false, MenuTitle ="Indigo", DefaultTitleColor = Color.Indigo },
                new BindableCheckBoxViewModel() { IsEnabled = true, IsChecked = false, MenuTitle ="Firebrick", DefaultTitleColor = Color.Firebrick },
            };

            RadioButtonTappedCommand = new Command(RadioButtonTapped);
            CheckBoxTappedCommand = new Command(CheckBoxTapped);
        }

        private void CheckBoxTapped()
        {
            foreach (BindableCheckBoxViewModel check in ListCheckBox)
            {
                if (check.MenuTitle == SelectedCheckBox.MenuTitle)
                    check.IsChecked = !check.IsChecked;
            }
        }

        private void RadioButtonTapped()
        {
            foreach (BindableRadioButtonViewModel radio in ListRadioButton)
            {
                if (radio.MenuTitle == SelectedRadioButton.MenuTitle)
                    radio.IsSelected = true;
                else
                    radio.IsSelected = false;

            }

            foreach (BindableCheckBoxViewModel check in ListCheckBox)
            {
                check.SetEnable(SelectedRadioButton.EnableProperty);
            }
        }
    }
}
