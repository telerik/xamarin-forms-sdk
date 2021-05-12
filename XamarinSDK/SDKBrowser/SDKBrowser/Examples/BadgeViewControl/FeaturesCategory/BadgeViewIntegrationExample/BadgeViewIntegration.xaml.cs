using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.BadgeViewControl.FeaturesCategory.BadgeViewIntegrationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BadgeViewIntegration : ContentView
    {
        public BadgeViewIntegration()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
        // >> badge-integration-open-drawer
        private void ImageTapped(object sender, EventArgs e)
        {
            this.drawer.IsOpen = !this.drawer.IsOpen;
        }
        // << badge-integration-open-drawer
    }
}