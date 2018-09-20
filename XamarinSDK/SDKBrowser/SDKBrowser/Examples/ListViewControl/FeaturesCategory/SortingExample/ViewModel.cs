using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.SortingExample
{
    // >> listview-features-sorting-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            this.Items = GetData();
        }

        public ObservableCollection<Item> Items { get; set; }

        private static ObservableCollection<Item> GetData()
        {
            var items = new ObservableCollection<Item>();

            items.Add(new Item { Name = "Tom", Age = 41 });
            items.Add(new Item { Name = "Anna", Age = 32 });
            items.Add(new Item { Name = "Peter", Age = 28 });
            items.Add(new Item { Name = "Teodor", Age = 39 });
            items.Add(new Item { Name = "Lorenzo", Age = 25 });
            items.Add(new Item { Name = "Andrea", Age = 33 });
            items.Add(new Item { Name = "Martin", Age = 36 });
            items.Add(new Item { Name = "Alexander", Age = 29 });
            items.Add(new Item { Name = "Maria", Age = 22 });
            items.Add(new Item { Name = "Elena", Age = 27 });
            items.Add(new Item { Name = "Stefano", Age = 44 });
            items.Add(new Item { Name = "Jake", Age = 31 });
            items.Add(new Item { Name = "Leon", Age = 28 });

            return items;
        }
    }
    // << listview-features-sorting-viewmodel
}
