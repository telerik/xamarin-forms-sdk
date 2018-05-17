using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TabViewControl.FeaturesCategory.SelectionExample
{
    public class Selection : ContentView
    {
        public Selection()
        {
            // >> tabview-features-selection-csharp
            RadTabView tabView = new RadTabView();
            tabView.Items.Add(new Telerik.XamarinForms.Primitives.TabViewItem() { HeaderText = "Home" });
            tabView.Items.Add(new Telerik.XamarinForms.Primitives.TabViewItem() { HeaderText = "Folder" });
            tabView.Items.Add(new Telerik.XamarinForms.Primitives.TabViewItem() { HeaderText = "View" });

            tabView.SelectedItem = tabView.Items[1];
            // << tabview-features-selection-csharp

            this.Content = tabView;
        }
    }
}
