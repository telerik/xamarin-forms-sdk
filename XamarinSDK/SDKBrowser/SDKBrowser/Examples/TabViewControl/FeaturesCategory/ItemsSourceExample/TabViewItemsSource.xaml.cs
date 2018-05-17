using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabViewControl.FeaturesCategory.ItemsSourceExample
{
    public partial class TabViewItemsSource : ContentView
    {
        public TabViewItemsSource()
        {
            this.InitializeComponent();

            this.BindingContext = new ObservableCollection<NavItem>
            {
                new NavItem { HeaderTitle = "item 1", BadgeCount = 14, Text = "Some text for item 1", },
                new NavItem { HeaderTitle = "item 2", BadgeCount = 18, Text = "Some text for item 2", },
                new NavItem { HeaderTitle = "item 3", BadgeCount = 12, Text = "Some text for item 3", },
                new NavItem { HeaderTitle = "item 4", BadgeCount = 17, Text = "Some text for item 4", },
                new NavItem { HeaderTitle = "item 5", BadgeCount = 16, Text = "Some text for item 5", },
            };
        }
    }
}
