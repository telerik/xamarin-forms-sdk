using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabView
{
    public class Selection : ContentPage
    {
        public Selection()
        {
            // >> tabview-features-selection-csharp     
            RadTabView tabView = new RadTabView();
            tabView.Items.Add(new TabViewItem() { HeaderText = "Home" });
            tabView.Items.Add(new TabViewItem() { HeaderText = "Folder" });
            tabView.Items.Add(new TabViewItem() { HeaderText = "View" });

            tabView.SelectedItem = tabView.Items[1];
            // << tabview-features-selection-csharp            

            this.Content = tabView;
        }
    }
}
