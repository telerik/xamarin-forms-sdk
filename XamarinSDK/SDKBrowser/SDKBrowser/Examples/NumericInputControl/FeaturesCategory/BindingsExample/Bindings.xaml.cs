using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.NumericInputControl.FeaturesCategory.BindingsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bindings : ContentView
    {
        public Bindings()
        {
            this.InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}