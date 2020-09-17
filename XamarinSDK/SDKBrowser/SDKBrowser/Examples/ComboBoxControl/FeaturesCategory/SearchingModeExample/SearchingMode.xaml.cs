using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SearchingModeExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchingMode : ContentView
    {
        public SearchingMode()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}