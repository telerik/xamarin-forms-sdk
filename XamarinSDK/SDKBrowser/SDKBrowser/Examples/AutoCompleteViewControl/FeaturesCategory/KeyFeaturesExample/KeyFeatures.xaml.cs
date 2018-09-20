
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.KeyFeaturesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeyFeatures : ContentView
    {
        public KeyFeatures()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();

            this.autoCompleteViewTokens.AutomationId = "tokensAutoCompleteView";
            this.autoCompleteViewFilter.AutomationId = "filteringAutoCompleteView";
            this.autoCompleteViewWatermark.AutomationId = "watermarkAutoCompleteView";
            this.autoCompleteViewClearButtonVisibility.AutomationId = "clearButtonVisibilityAutoCompleteView";
            this.autoCompleteViewNoResults.AutomationId = "noResultsAutoCompleteView";
            this.autoCompleteViewSearchTreshold.AutomationId = "searchThresholdAutoCompleteView";
            this.autoCompleteViewSuggestionView.AutomationId = "suggestionViewAutoCompleteView";
        }
    }
}