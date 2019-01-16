using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ItemTemplateExample
{
    // >> treeview-itemtemplate-viewmodel
    public class ViewModel
    {
        public ObservableCollection<Country> Source { get; set; }

        public ViewModel()
        {
            this.Source = new ObservableCollection<Country>();
            this.Source.Add(new Country()
            {
                Name = "Italy",
                Icon = "TreeView_Flag_Italy.png",
                Cities = new ObservableCollection<City>()
                {
                    new City() { Name = "Rome"},
                    new City() { Name = "Milano"}
                }
            });
            this.Source.Add(new Country()
            {
                Name = "Germany",
                Icon = "TreeView_Flag_Germany.png",
                Cities = new ObservableCollection<City>()
                {
                    new City() { Name = "Berlin"},
                    new City() { Name = "Frankfurt"}
                }
            });
            this.Source.Add(new Country()
            {
                Name = "India",
                Icon = "TreeView_Flag_India.png",
                Cities = new ObservableCollection<City>()
                {
                    new City() { Name = "Mumbai"}
                }
            });
            this.Source.Add(new Country()
            {
                Name = "Argentina",
                Icon = "TreeView_Flag_Argentina.png",
                Cities = new ObservableCollection<City>()
                {
                    new City() { Name = "Buenos Aires"} 
                }
            });
            this.Source.Add(new Country()
            {
                Name = "USA",
                Icon = "TreeView_Flag_USA.png",
                Cities = new ObservableCollection<City>()
                {
                    new City() { Name = "Miami"},
                    new City() { Name = "New York"},
                    new City() { Name = "Los Angeles"}
                }
            });
        }
    }
    // << treeview-itemtemplate-viewmodel
}