using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.EntryControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            this.InitializeComponent();
        }
        // >> entry-features-textselection-code
        private void FocusButtonClicked(object sender, System.EventArgs e)
        {
            selectEntry.Focus();
            selectEntry.CursorPosition = 7;
            selectEntry.SelectionLength = 9;
        }
        // << entry-features-textselection-code
    }
}