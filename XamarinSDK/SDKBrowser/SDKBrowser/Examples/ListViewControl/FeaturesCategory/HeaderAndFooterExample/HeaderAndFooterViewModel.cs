using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.HeaderAndFooterExample
{
    // >> listview-features-header-and-footer-viewmodel
    public class HeaderAndFooterViewModel
    {
        public HeaderAndFooterViewModel()
        {
            this.Items = GetItems(20);
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
    // << listview-features-header-and-footer-viewmodel
}
