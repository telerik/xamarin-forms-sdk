using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory.ItemTemplateExample
{
    // >> treeview-itemtemplate-country
    public class Country
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public ObservableCollection<City> Cities { get; set; }
    }
    // << treeview-itemtemplate-country
}
