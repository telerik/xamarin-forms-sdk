using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SDKBrowser.Examples.ListView
{
    public class FirstLookViewModel
    {
        public FirstLookViewModel()
        {
            this.Items = GetItems(100);
        }
 
        public ObservableCollection<string> Items { get; set; }

        private static ObservableCollection<string> GetItems(int count)
        {
            var items = new ObservableCollection<string>();
            for (int i = 0; i < count; i++)
            {
                items.Add(string.Format("item {0}", i));
            }

            return items;
        }
    }
}