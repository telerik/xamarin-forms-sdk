using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.SpecialSlotsStyleSelectorExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecialSlotsStyleSelector : ContentView
    {
        public SpecialSlotsStyleSelector()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}