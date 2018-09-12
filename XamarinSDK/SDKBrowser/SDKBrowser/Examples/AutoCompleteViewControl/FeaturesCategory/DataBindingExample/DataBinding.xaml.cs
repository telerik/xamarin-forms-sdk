using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.DataBindingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBinding : ContentView
    {
        public DataBinding()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();

            // >> autocompleteview-focused
            this.autoCompleteView.Focused += this.AutoCompleteView_Focused;
            // << autocompleteview-focused
        }

        // >> autocompleteview-showsuggestions
        private void AutoCompleteView_Focused(object sender, FocusEventArgs e)
        {
            this.autoCompleteView.ShowSuggestions();
        }
        // << autocompleteview-showsuggestions
    }
}