using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.HeaderAndFooterExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderAndFooter : ContentView
    {
        public HeaderAndFooter ()
        {
            InitializeComponent ();
            this.BindingContext = new HeaderAndFooterViewModel();
        }
    }
}