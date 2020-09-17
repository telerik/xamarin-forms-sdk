using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingCommandsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulingCommands : ContentView
    {
        public SchedulingCommands()
        {
            InitializeComponent();

            this.BindingContext = new ViewModel();
        }
    }
}