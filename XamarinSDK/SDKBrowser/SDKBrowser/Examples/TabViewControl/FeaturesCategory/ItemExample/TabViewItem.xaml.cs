using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabViewControl.FeaturesCategory.ItemExample
{
    public partial class TabViewItem : ContentView
    {
        public TabViewItem()
        {
            this.InitializeComponent();

            // >> tabview-features-tabviewitem-csharp
            RadTabView tabView = new RadTabView();
            Telerik.XamarinForms.Primitives.TabViewItem homeTab = new Telerik.XamarinForms.Primitives.TabViewItem()
            {
                HeaderText = "Home",
                Content = new Label()
                {
                    Text = "This is the content of the Home tab",
                    Margin = new Thickness(10)
                },
            };
            Telerik.XamarinForms.Primitives.TabViewItem viewTab = new Telerik.XamarinForms.Primitives.TabViewItem()
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
            Telerik.XamarinForms.Primitives.TabViewItem folderTab = new Telerik.XamarinForms.Primitives.TabViewItem()
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
