using System;
using Xamarin.Forms;

namespace SDKBrowser.Examples.SideDrawerControl.GettingStartedCategory.GettingStartedExample
{
    public partial class SideDrawerGettingStartedXaml : ContentView
    {
        public SideDrawerGettingStartedXaml()
        {
            this.InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            drawer.IsOpen = !drawer.IsOpen;
        }
    }
}
