using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace samplecode.HorizontalListView
{
    public class HorizontalViewModel : BaseViewModel
    {
        private ObservableCollection<HorizontalItem> horizontalItems;
        public ObservableCollection<HorizontalItem> HorizontalItems
        {
            get => horizontalItems;
            set => SetProperty(ref horizontalItems, value);
        }

        private HorizontalItem selectedItem;
        public HorizontalItem SelectedItem
        {
            get => selectedItem;
            set 
            {
                SetProperty(ref selectedItem, value);
                ItemSelected();
            } 
        }

        public HorizontalViewModel()
        {
            HorizontalItems = new ObservableCollection<HorizontalItem>()
            {
                new HorizontalItem() { Title = "One", Icon = "one.png" },
                new HorizontalItem() { Title = "Two", Icon = "two.png" },
                new HorizontalItem() { Title = "Three", Icon = "three.png" },
                new HorizontalItem() { Title = "Four", Icon = "four.png" },
                new HorizontalItem() { Title = "Five", Icon = "five.png" },
                new HorizontalItem() { Title = "Six", Icon = "six.png" },
                new HorizontalItem() { Title = "Seven", Icon = "seven.png" },
                new HorizontalItem() { Title = "Eight", Icon = "eight.png" },
                new HorizontalItem() { Title = "Nine", Icon = "nine.png" },
                new HorizontalItem() { Title = "Ten", Icon = "ten.png" },
            };
        }

        private void ItemSelected()
        {
            MessagingCenter.Send(this, "ItemSelected", SelectedItem);
        }
    }
}
