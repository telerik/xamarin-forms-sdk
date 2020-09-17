using SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SearchingModeExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.TemplatesCategory.ItemSelectedItemTemplatesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemSelectedItemTemplates : ContentView
    {
        public ItemSelectedItemTemplates()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}