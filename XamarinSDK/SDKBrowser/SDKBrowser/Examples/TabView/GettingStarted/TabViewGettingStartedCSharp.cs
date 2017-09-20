using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabView
{
    public class TabViewGettingStartedCSharp : ContentPage
    {
        public TabViewGettingStartedCSharp()
        {
            // >> tabview-getting-started-csharp
            RadTabView tabView = new RadTabView(); 
             TabViewItem homeTab = new TabViewItem()
            {
                HeaderText = "Home",
                Content = new Label() { Text = "This is the content of the Home tab", Margin = new Thickness(10) },
            };
            TabViewItem folderTab = new TabViewItem()
            {
                HeaderText = "Folder",
                Content = new Label() { Text = "This is the content of the Folder tab", Margin = new Thickness(10) },
            };
            TabViewItem viewTab = new TabViewItem()
            {
                HeaderText = "View",
                Content = new Label() { Text = "This is the content of the View tab", Margin = new Thickness(10) },
            };
            tabView.Items.Add(homeTab);
            tabView.Items.Add(folderTab);
            tabView.Items.Add(viewTab);
            // << tabview-getting-started-csharp

            this.Content = tabView;
        }
    }
}

