using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PopupControl.GettingStartedCategory.GettingStartedExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupGettingStartedXaml : ContentView
    {
        public PopupGettingStartedXaml ()
        {
            InitializeComponent ();
        }
        // >> popup-gettingstarted-events
        private void ClosePopup(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }
        private void ShowPopup(object sender, EventArgs e)
        {
            popup.IsOpen = true;
        }
        // << popup-gettingstarted-events
    }
}