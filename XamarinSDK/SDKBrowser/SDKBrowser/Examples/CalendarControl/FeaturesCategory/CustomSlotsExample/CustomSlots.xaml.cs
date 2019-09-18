using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CustomSlotsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSlots : ContentView
    {
        public CustomSlots()
        {
            InitializeComponent();

            // >> calendar-customslots-setvm
            this.BindingContext = new ViewModel();
            // << calendar-customslots-setvm
        }
    }
}