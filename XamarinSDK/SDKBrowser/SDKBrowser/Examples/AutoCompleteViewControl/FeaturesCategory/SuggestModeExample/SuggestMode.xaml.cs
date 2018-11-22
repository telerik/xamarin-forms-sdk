using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.SuggestModeExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuggestMode : ContentView
    {
        public SuggestMode()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}