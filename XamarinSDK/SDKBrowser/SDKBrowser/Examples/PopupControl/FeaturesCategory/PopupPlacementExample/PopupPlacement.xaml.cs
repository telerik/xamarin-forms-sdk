using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PopupControl.FeaturesCategory.PopupPlacementExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPlacement : ContentView
    {
        public PopupPlacement ()
        {
            InitializeComponent ();
        }

        // >> popup-features-placement-event
        private void ShowPopup(object sender, EventArgs e)
        {
            popup.IsOpen = true;
        }
        // << popup-features-placement-event
    }
}