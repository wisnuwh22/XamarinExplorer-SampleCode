using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace samplecode.NestedCheckBox
{
    public class ParentCheckBoxViewModel : BaseViewModel
    {

        protected bool isChecked;
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                SetProperty(ref isChecked, value);
                UpdateChildren();
                UpdateImageSource();
            }
        }

        protected string menuTitle;
        public String MenuTitle
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

        protected ObservableCollection<ChildrenCheckBoxViewModel> children;
        public ObservableCollection<ChildrenCheckBoxViewModel> Children
        {
            get => children;
            set => SetProperty(ref children, value);
        }

        protected ChildrenCheckBoxViewModel selectedChild;
        public ChildrenCheckBoxViewModel SelectedChild
        {
            get => selectedChild;
            set => SetProperty(ref selectedChild, value);
        }

        public ICommand ChildTappedCommand { get; set; }

        public ParentCheckBoxViewModel(ObservableCollection<ChildrenCheckBoxViewModel> _children)
        {
            this.Children = _children;
            ChildTappedCommand = new Command(ChildTapped);
            IsChecked = false;
            SetParent();

        }

        private void ChildTapped()
        {
            foreach (ChildrenCheckBoxViewModel child in Children)
            {
                if (child.MenuTitle == SelectedChild.MenuTitle)
                    child.IsChecked = !child.IsChecked;
            }
        }

        protected void SetParent()
        {
            foreach (ChildrenCheckBoxViewModel child in Children)
            {
                child.Parent = this;
                child.IsChecked = false;
            }
        }

        protected void UpdateChildren()
        {
            if (IsChecked)
            {
                foreach (ChildrenCheckBoxViewModel child in Children)
                {
                    child.IsChecked = true;
                }
            }
        }

        protected void UpdateImageSource()
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

    }
}
