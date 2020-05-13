using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.CommandsCategory.AppointmentTapExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentTap : ContentView
    {
        public AppointmentTap()
        {
            InitializeComponent();
            // >> calendar-commands-appointmenttap-cs
            this.calendar.Commands.Add(new AppointmentTapUserCommand());
            // << calendar-commands-appointmenttap-cs
        }
    }
}