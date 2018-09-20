using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.TypingIndicatorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TypingIndicatorItemsSource : ContentView
    {
        public TypingIndicatorItemsSource()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}