using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.TemplatedPickerControl.FeaturesCategory.StylingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Styling : ContentView
    {
        public Styling()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel();
        }
    }
}