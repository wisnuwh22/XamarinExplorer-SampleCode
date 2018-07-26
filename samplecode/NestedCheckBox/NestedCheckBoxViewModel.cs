using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace samplecode.NestedCheckBox
{
    public class NestedCheckBoxViewModel : BaseViewModel
    {
        protected ObservableCollection<ChildrenCheckBoxViewModel> listChildren1;
        public ObservableCollection<ChildrenCheckBoxViewModel> ListChildren1
        {
            get => listChildren1;
            set => SetProperty(ref listChildren1, value);
        }

        protected ObservableCollection<ChildrenCheckBoxViewModel> listChildren2;
        public ObservableCollection<ChildrenCheckBoxViewModel> ListChildren2
        {
            get => listChildren2;
            set => SetProperty(ref listChildren2, value);
        }

        protected ObservableCollection<ChildrenCheckBoxViewModel> listChildren3;
        public ObservableCollection<ChildrenCheckBoxViewModel> ListChildren3
        {
            get => listChildren3;
            set => SetProperty(ref listChildren3, value);
        }

        protected ObservableCollection<ChildrenCheckBoxViewModel> listChildren4;
        public ObservableCollection<ChildrenCheckBoxViewModel> ListChildren4
        {
            get => listChildren4;
            set => SetProperty(ref listChildren4, value);
        }

        protected ObservableCollection<ChildrenCheckBoxViewModel> listChildren5;
        public ObservableCollection<ChildrenCheckBoxViewModel> ListChildren5
        {
            get => listChildren5;
            set => SetProperty(ref listChildren5, value);
        }

        protected ObservableCollection<ParentCheckBoxViewModel> listParent;
        public ObservableCollection<ParentCheckBoxViewModel> ListParent
        {
            get => listParent;
            set => SetProperty(ref listParent, value);
        }

        protected ParentCheckBoxViewModel selectedParent;
        public ParentCheckBoxViewModel SelectedParent
        {
            get => selectedParent;
            set => SetProperty(ref selectedParent, value);
        }

        public ICommand ParentTappedCommand { get; set; }


        public NestedCheckBoxViewModel()
        {
            ListChildren1 = new ObservableCollection<ChildrenCheckBoxViewModel>()
            {
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 1.1" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 1.2" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 1.3" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 1.4" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 1.5" },
            };

            ListChildren2 = new ObservableCollection<ChildrenCheckBoxViewModel>()
            {
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 2.1" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 2.2" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 2.3" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 2.4" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 2.5" },
            };

            ListChildren3 = new ObservableCollection<ChildrenCheckBoxViewModel>()
            {
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 3.1" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 3.2" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 3.3" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 3.4" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 3.5" },
            };

            ListChildren4 = new ObservableCollection<ChildrenCheckBoxViewModel>()
            {
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 4.1" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 4.2" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 4.3" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 4.4" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 4.5" },
            };

            ListChildren5 = new ObservableCollection<ChildrenCheckBoxViewModel>()
            {
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 5.1", },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 5.2" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 5.3" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 5.4" },
                new ChildrenCheckBoxViewModel(){ MenuTitle = "Child CheckBox 5.5" },
            };

            ListParent = new ObservableCollection<ParentCheckBoxViewModel>()
            {
                new ParentCheckBoxViewModel(ListChildren1){ MenuTitle = "Parent Checkbox 1" },
                new ParentCheckBoxViewModel(ListChildren2){ MenuTitle = "Parent Checkbox 2" },
                new ParentCheckBoxViewModel(ListChildren3){ MenuTitle = "Parent Checkbox 3" },
                new ParentCheckBoxViewModel(ListChildren4){ MenuTitle = "Parent Checkbox 4" },
                new ParentCheckBoxViewModel(ListChildren5){ MenuTitle = "Parent Checkbox 5" },
            };

            ParentTappedCommand = new Command(ParentTapped);
        }

        private void ParentTapped()
        {
            foreach (ParentCheckBoxViewModel parent in ListParent)
            {
                if (parent.MenuTitle == SelectedParent.MenuTitle)
                    parent.IsChecked = !parent.IsChecked;
            }
        }
    }
}
