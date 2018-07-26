using System;
namespace samplecode.NestedCheckBox
{
	public class ChildrenCheckBoxViewModel : BaseViewModel
    {

        protected bool isChecked;
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                SetProperty(ref isChecked, value);
                UpdateImageSource();
                UpdateParent();
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

        protected ParentCheckBoxViewModel parent;
        public ParentCheckBoxViewModel Parent
        {
            get => parent;
            set => SetProperty(ref parent, value);
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

        protected void UpdateParent()
        {
            if (!IsChecked)
            {
                Parent.IsChecked = false;
            }
        }
    }
}
