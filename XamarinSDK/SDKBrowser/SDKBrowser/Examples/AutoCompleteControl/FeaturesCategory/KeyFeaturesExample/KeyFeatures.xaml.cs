using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            this.InitializeComponent();

            this.BindingContext = new ViewModel();

            this.autoCompleteTokens.AutomationId = "tokensAutoComplete";
            this.autoCompleteFilter.AutomationId = "filteringAutoComplete";
            this.autoCompleteWatermark.AutomationId = "watermarkAutoComplete";
            this.autoCompleteNoResults.AutomationId = "noResultsAutoComplete";
            this.autoCompleteSearchTreshold.AutomationId = "searchThresholdAutoComplete";
            this.autoCompleteSuggestionView.AutomationId = "suggestionViewAutoComplete";
        }
    }
}