using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.TreeViewControl.FeaturesCategory
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
            this.Children = new ObservableCollection<Item>();
        }

        public string Name { get; set; }
        public IList<Item> Children { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
