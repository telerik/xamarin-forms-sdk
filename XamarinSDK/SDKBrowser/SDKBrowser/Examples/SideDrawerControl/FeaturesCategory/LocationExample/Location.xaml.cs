using System;
using Telerik.XamarinForms.Primitives.SideDrawer;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SideDrawerControl.FeaturesCategory.LocationExample
{
    public partial class Location : ContentView
    {
        public Location()
        {
            this.InitializeComponent();

            this.drawerList.ItemsSource = new []
            {
                "Inbox",
                "Drafts",
                "Sent Items"
            };

            this.picker.ItemsSource = Enum.GetValues(typeof(SideDrawerLocation));
            this.picker.SelectedItem = SideDrawerLocation.Left;
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            drawer.DrawerLocation = (SideDrawerLocation)this.picker.SelectedItem;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;
        }
    }
}
