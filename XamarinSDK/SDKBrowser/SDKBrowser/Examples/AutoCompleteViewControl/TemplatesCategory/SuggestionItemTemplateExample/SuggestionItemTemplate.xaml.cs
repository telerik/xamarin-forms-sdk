using SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.TemplatesCategory.SuggestionItemTemplateExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuggestionItemTemplate : ContentView
    {
        public SuggestionItemTemplate ()
        {
            InitializeComponent ();
            this.BindingContext = new ViewModel();
        }
    }
}