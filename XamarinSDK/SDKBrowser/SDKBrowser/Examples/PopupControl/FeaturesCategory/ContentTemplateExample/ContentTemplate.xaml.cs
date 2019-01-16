using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Telerik.XamarinForms.Primitives.CheckBox;

namespace SDKBrowser.Examples.PopupControl.FeaturesCategory.ContentTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentTemplate : ContentView
    {
        public ContentTemplate ()
        {
            InitializeComponent ();
        }
        // >> popup-features-contenttemplate-events
        private void ClosePopup(object sender, EventArgs e)
        {
            popup.IsOpen = false;
        }
        private void Checkbox_IsCheckedChanged(object sender, IsCheckedChangedEventArgs e)
        {
            if (e.NewValue == true)
                popup.IsOpen = true;
        }
        // << popup-features-contenttemplate-events
    }
}