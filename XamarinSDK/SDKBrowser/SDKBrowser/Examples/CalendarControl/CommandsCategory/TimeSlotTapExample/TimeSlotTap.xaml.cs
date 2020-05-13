using System.Windows.Input;
using Telerik.XamarinForms.Input.Calendar.Commands;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.CommandsCategory.TimeSlotTapExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    // >> calendar-commands-timeslottap
    public partial class TimeSlotTap : ContentView
    {
        public TimeSlotTap()
        {
            InitializeComponent();

            this.TimeSlotTapCommand = new Command(this.OnTimeSlotTapped);
            this.BindingContext = this;
        }

        public ICommand TimeSlotTapCommand { get; set; }

        private void OnTimeSlotTapped(object obj)
        {
            var args = (TimeSlotTapCommandContext)obj;
            Application.Current.MainPage.DisplayAlert("TimeSlotTap Command", "Start Time is " + args.StartTime + " and Endtime is " + args.EndTime, "OK");
        }
    }
    // << calendar-commands-timeslottap
}