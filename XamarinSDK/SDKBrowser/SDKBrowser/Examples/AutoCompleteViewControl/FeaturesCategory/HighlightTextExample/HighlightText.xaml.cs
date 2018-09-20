using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.AutoCompleteViewControl.FeaturesCategory.HighlightTextExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HighlightText : ContentView
    {
        public HighlightText()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}