using System;
using System.Collections.ObjectModel;
using System.Linq;
using samplecode.CustomControls;

namespace samplecode.AccordionListView
{
    public class AccordionViewModel : BaseViewModel
    {
        private CustomObservableCollection<Country> countries;
        public CustomObservableCollection<Country> Countries
        {
            get => countries;
            set => SetProperty(ref countries, value);
        }

        public AccordionViewModel()
        {
            ObservableCollection<City> USACities = new ObservableCollection<City>()
            {
                new City(){ CityName = "Washington DC" },
                new City(){ CityName = "New York" },
                new City(){ CityName = "Los Angeles" }
            };

            ObservableCollection<City> ChinaCities = new ObservableCollection<City>()
            {
                new City(){ CityName = "Beijing" },
                new City(){ CityName = "Shanghai" },
                new City(){ CityName = "Shenzhen" }
            };

            ObservableCollection<City> RussiaCities = new ObservableCollection<City>()
            {
                new City(){ CityName = "Moscow" },
                new City(){ CityName = "St. Peterburg" },
                new City(){ CityName = "Kazan" }
            };

            countries = new CustomObservableCollection<Country>()
            {
                new Country(){ CountryName = "USA", IsChildrenVisible = false, Cities = USACities },
                new Country(){ CountryName = "China", IsChildrenVisible = false, Cities = ChinaCities },
                new Country(){ CountryName = "Russia", IsChildrenVisible = false, Cities = RussiaCities },
            };
        }

        public void ShowCities(string countryName)
        {
            Country country = Countries.SingleOrDefault(c => c.CountryName == countryName);
            country.IsChildrenVisible = !country.IsChildrenVisible;
            Countries.ReportItemChange(country);
        }
    }
}
