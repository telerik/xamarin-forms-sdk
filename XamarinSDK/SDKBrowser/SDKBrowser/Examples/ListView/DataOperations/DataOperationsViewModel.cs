using System;
using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ListView
{
    public class DataOperationsViewModel
    {
        private static int[] randomNumbers = new int[100] { 41, 39, 34, 24, 29, 27, 24, 25, 27, 33, 35, 39, 31, 30, 23, 39, 36, 33, 38, 27, 39, 41, 22, 34, 27, 37, 31, 35, 35, 41, 40, 31, 20, 21, 31, 40, 22, 24, 23, 26, 24, 38, 32, 40, 23, 25, 28, 36, 30, 41, 27, 29, 38, 28, 34, 35, 25, 31, 41, 32, 38, 40, 32, 33, 20, 40, 32, 26, 36, 26, 26, 39, 35, 35, 40, 27, 27, 23, 31, 33, 27, 41, 32, 38, 39, 22, 38, 29, 29, 30, 25, 32, 24, 30, 21, 30, 36, 41, 38, 24 };

        public DataOperationsViewModel()
        {
            this.Items = GetData(500);
        }

        public ObservableCollection<Item> Items { get; set; }

        private static ObservableCollection<Item> GetData(int count)
        {
            var items = new ObservableCollection<Item>();

            for (var i = 0; i < count; i++)
            {
                items.Add(new Item { Name = string.Format("Customer {0}", i), Age = randomNumbers[i % randomNumbers.Length] });
            }

            return items;
        }
    }
}