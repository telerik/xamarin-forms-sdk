using System;
using System.Linq;
using Telerik.XamarinForms.Primitives;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SideDrawerControl.FeaturesCategory.TransitionsExample
{
    public partial class Transitions : ContentView
    {
        public Transitions()
        {
            this.InitializeComponent();

            this.drawerList.ItemsSource = new[]
            {
                "Inbox",
                "Drafts",
                "Sent Items"
            };

            this.picker.ItemsSource = Enum.GetValues(typeof(SideDrawerTransitionType)).OfType<SideDrawerTransitionType>().Where(item => item != SideDrawerTransitionType.Custom).ToList();
            this.picker.SelectedItem = SideDrawerTransitionType.Push;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            this.drawer.IsOpen = !this.drawer.IsOpen;
        }
    }
}