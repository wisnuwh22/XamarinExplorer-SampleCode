using System;
using System.Collections.ObjectModel;

namespace samplecode.AccordionListView
{
    public class City
    {
        public string CityName { get; set; }
    }

    public class Country
    {
        public string CountryName { get; set; }
        public bool IsChildrenVisible { get; set; }
        public string ArrowIconSource
        {
            get
            {
                if (IsChildrenVisible)
                    return "uparrow.png";
                else
                    return "downarrow.png";
            }
        }
        public ObservableCollection<City> Cities { get; set; }
        public int ChildrenRowHeightRequest
        {
            get
            {
                if (Cities != null)
                    return Cities.Count * 50;
                else
                    return 0;   
            }
        }
    }
}
