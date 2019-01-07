using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace samplecode.GridMenu
{
    public class BreakfastViewModel : BaseViewModel
    {
        private ObservableCollection<BreakfastMenu> breakfastMenuList;
        private BreakfastMenu selectedBreakfastMenu;
        public ObservableCollection<BreakfastMenu> BreakfastMenuList
        {
            get => breakfastMenuList;
            set => SetProperty(ref breakfastMenuList, value);
        }
        public BreakfastMenu SelectedBreakfastMenu
        {
            get => selectedBreakfastMenu;
            set => SetProperty(ref selectedBreakfastMenu, value);
        }

        public ICommand MenuTappedCommand { get; set; }

        public BreakfastViewModel()
        {
            BreakfastMenuList = new ObservableCollection<BreakfastMenu>()
            {
                new BreakfastMenu() { ImageSource = "Burger.png", MenuTitle = "BURGER", BackgroundColor="#50616e" },
                new BreakfastMenu() { ImageSource = "Pizza.png", MenuTitle = "PIZZA", BackgroundColor="#093f89" },
                new BreakfastMenu() { ImageSource = "EggBacon.png", MenuTitle = "BACON", BackgroundColor="#00a5ec" },
                new BreakfastMenu() { ImageSource = "Sandwich.png", MenuTitle = "SANDWICH", BackgroundColor="#37248a" },
            };
            MenuTappedCommand = new Command(() => MenuSelected());
        }

        private void MenuSelected()
        {
            NavigationPage navPage = new NavigationPage();
            NavigationViewModel navViewModel = new NavigationViewModel();

            switch (SelectedBreakfastMenu.MenuTitle)
            {
                case "BURGER":
                    navPage = new NavigationPage(new BreakfastBurger());
                    break;
                case "PIZZA":
                    navPage = new NavigationPage(new BreakfastPizza());
                    break;
                case "BACON":
                    navPage = new NavigationPage(new BreakfastBacon());
                    break;
                case "SANDWICH":
                    navPage = new NavigationPage(new BreakfastSandwich());
                    break;
            }

            navViewModel.BarBackgroundColor = Color.FromHex(SelectedBreakfastMenu.BackgroundColor);
            navPage.BindingContext = navViewModel;
            navPage.SetBinding(NavigationPage.BarBackgroundColorProperty, new Binding("BarBackgroundColor"));
            Application.Current.MainPage = navPage;
        }
    }

    public class NavigationViewModel : BaseViewModel
    {
        Color barBackgroundColor = Color.Transparent;
        public Color BarBackgroundColor
        {
            get => barBackgroundColor;
            set => SetProperty(ref barBackgroundColor, value);
        }
    }

}
