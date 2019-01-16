using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.PopupControl.FeaturesCategory.ModalPopupExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPopup : ContentView
    {
        public ModalPopup ()
        {
            InitializeComponent ();
        }
        // >> popup-features-modal-events
        private void ClosePopup(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }
        private void ShowPopup(object sender, EventArgs e)
        {
            popup.IsOpen = true;
        }
        // << popup-features-modal-events
    }
}