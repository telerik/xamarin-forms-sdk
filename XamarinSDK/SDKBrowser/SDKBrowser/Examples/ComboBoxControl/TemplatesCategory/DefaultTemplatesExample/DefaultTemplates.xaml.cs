using SDKBrowser.Examples.ComboBoxControl.FeaturesCategory.SearchingModeExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ComboBoxControl.TemplatesCategory.DefaultTemplatesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DefaultTemplates : ContentView
    {
        public DefaultTemplates()
        {
            InitializeComponent();
            // >> combobox-default-templates-vm
            this.BindingContext = new ViewModel();
            // << combobox-default-templates-vm
        }
    }
}
