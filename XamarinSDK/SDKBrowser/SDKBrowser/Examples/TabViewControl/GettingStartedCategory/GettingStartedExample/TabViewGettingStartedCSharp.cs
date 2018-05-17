using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabViewControl.GettingStartedCategory.GettingStartedExample
{
    public class TabViewGettingStartedCSharp : ContentView
    {
        public TabViewGettingStartedCSharp()
        {
            // >> tabview-getting-started-csharp
            RadTabView tabView = new RadTabView();
            Telerik.XamarinForms.Primitives.TabViewItem homeTab = new Telerik.XamarinForms.Primitives.TabViewItem()
            {
                HeaderText = "Home",
                Content = new Label() { Text = "This is the content of the Home tab", Margin = new Thickness(10) },
            };
            Telerik.XamarinForms.Primitives.TabViewItem folderTab = new Telerik.XamarinForms.Primitives.TabViewItem()
            {
                HeaderText = "Folder",
                Content = new Label() { Text = "This is the content of the Folder tab", Margin = new Thickness(10) },
            };
            Telerik.XamarinForms.Primitives.TabViewItem viewTab = new Telerik.XamarinForms.Primitives.TabViewItem()
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

