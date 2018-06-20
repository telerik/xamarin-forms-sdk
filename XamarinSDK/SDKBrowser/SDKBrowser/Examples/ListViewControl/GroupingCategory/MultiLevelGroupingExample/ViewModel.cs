using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ListViewControl.GroupingCategory.MultiLevelGroupingExample
{
    // >> listview-grouping-multilevel-viewmodel
    public class ViewModel
    {
        public ObservableCollection<City> Cities { get; set; }

        public ViewModel()
        {
            this.Cities = new ObservableCollection<City>()
            {
                new City() { Name = "Barcelona", Country = "Spain", Continent = "Europe"},
                new City() { Name = "Madrid", Country = "Spain", Continent = "Europe" },
                new City() { Name = "Rome", Country = "Italy", Continent = "Europe" },
                new City() { Name = "Florence", Country = "Italy", Continent = "Europe" },
                new City() { Name = "London", Country = "England", Continent = "Europe" },
                new City() { Name = "Manchester", Country = "England", Continent = "Europe"},
                new City() { Name = "New York", Country = "USA", Continent = "North America" },
                new City() { Name = "Boston", Country = "USA",  Continent = "North America" }
             };
        }
    }
    // << listview-grouping-multilevel-viewmodel
}
