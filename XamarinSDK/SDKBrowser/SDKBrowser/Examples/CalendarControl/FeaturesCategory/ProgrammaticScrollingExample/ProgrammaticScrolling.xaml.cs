using System;
using System.Collections.ObjectModel;
using System.Linq;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.ProgrammaticScrollingExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgrammaticScrolling : ContentView
    {
        public ProgrammaticScrolling()
        {
            InitializeComponent();

            var date = DateTime.Today;

            this.calendar.AppointmentsSource = new ObservableCollection<Appointment> {
                new Appointment {
                    Title = "Meeting with Tom",
                    Detail = "Sea Garden",
                    StartDate = date.AddHours(10),
                    EndDate = date.AddHours(11),
                    Color = Color.Tomato
                },
                new Appointment {
                    Title = "Lunch with Sara",
                    Detail = "Restaurant",
                    StartDate = date.AddHours(12).AddMinutes(30),
                    EndDate = date.AddHours(14),
                    Color = Color.DarkTurquoise
                },
                new Appointment {
                    Title = "Elle Birthday",
                    StartDate = date.AddDays(1),
                    EndDate = date.AddDays(1).AddHours(12),
                    IsAllDay = true
                },
                    new Appointment {
                    Title = "Football Game",
                    StartDate = date.AddDays(2).AddHours(15),
                    EndDate = date.AddDays(2).AddHours(17),
                    Color = Color.Green
                }
            };
        }

        private void ScrollToAppointment(object sender, System.EventArgs e)
        {
            // >> calendar-scrolltoapp-code
            var app = (calendar.AppointmentsSource as ObservableCollection<Appointment>).First();
            calendar.ScrollAppointmentIntoView(app);
            // << calendar-scrolltoapp-code
        }

        private void ScrollToTime(object sender, System.EventArgs e)
        {
            // >> calendar-scrolltotime-code
            TimeSpan time = TimeSpan.FromHours(16);
            calendar.ScrollTimeIntoView(time);
            // << calendar-scrolltotime-code
        }
    }
}