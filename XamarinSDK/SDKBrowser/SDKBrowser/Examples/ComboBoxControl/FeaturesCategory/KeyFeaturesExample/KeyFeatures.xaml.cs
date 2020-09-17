using SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.EditingExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}