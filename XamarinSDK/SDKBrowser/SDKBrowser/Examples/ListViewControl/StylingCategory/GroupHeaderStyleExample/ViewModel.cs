using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.GroupHeaderStyleExample
{
    // >> listview-groupstyle-viewmodel
    public class ViewModel
    {
        public ObservableCollection<City> Cities { get; set; }

        public ViewModel()
        {
            this.Cities = new ObservableCollection<City>()
            {
                new City() { Name = "Barcelona", Country = "Spain"},
                new City() { Name = "Madrid", Country = "Spain"},
                new City() { Name = "Rome", Country = "Italy"},
                new City() { Name = "Florence", Country = "Italy"},
                new City() { Name = "London", Country = "England"},
                new City() { Name = "Manchester", Country = "England"},
                new City() { Name = "New York", Country = "USA"},
                new City() { Name = "Boston", Country = "USA"}
             };
        }
    }
    // << listview-groupstyle-viewmodel
}
