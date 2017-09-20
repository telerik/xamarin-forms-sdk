using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabView
{
    public partial class TabViewItemExample : ContentPage
    {        
        public TabViewItemExample()
        {
            InitializeComponent();

            // >> tabview-features-tabviewitem-csharp
            RadTabView tabView = new RadTabView();
            TabViewItem homeTab = new TabViewItem()
            {
                HeaderText = "Home",
                Content = new Label()
                {
                    Text = "This is the content of the Home tab",
                    Margin = new Thickness(10)
                },
            };
            TabViewItem viewTab = new TabViewItem()
            {
                HeaderText = "View",
                Content = new Label()
                {
                    Text = "This is the content of the View tab",
                    Margin = new Thickness(10)
                },
            };
            StackLayout folderTabHeaderPanel = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(5, 0, 0, 0),
            };
            folderTabHeaderPanel.Children.Add(new ContentView()
            {
                BackgroundColor = (Color)(new ColorTypeConverter()).ConvertFromInvariantString("#CA5100"),
                WidthRequest = 10,
                HeightRequest = 10,
                VerticalOptions = LayoutOptions.Center,
            });
            folderTabHeaderPanel.Children.Add(new Label() { Text = "Folder" });
            TabViewItem folderTab = new TabViewItem()
            {
                Header = new TabViewHeaderItem() { Content = folderTabHeaderPanel },
                Content = new Label()
                {
                    Text = "This is the content of the Folder tab",
                    Margin = new Thickness(10)
                },
            };

            tabView.Items.Add(homeTab);
            tabView.Items.Add(viewTab);
            tabView.Items.Add(folderTab);
            // << tabview-features-tabviewitem-csharp
        }
    }
}
