using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.SpecialSlotsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecialSlots : ContentView
    {
        public SpecialSlots()
        {
            InitializeComponent();

            // >> calendar-specialslots-setvm
            this.BindingContext = new ViewModel();
            // << calendar-specialslots-setvm
        }
    }
}