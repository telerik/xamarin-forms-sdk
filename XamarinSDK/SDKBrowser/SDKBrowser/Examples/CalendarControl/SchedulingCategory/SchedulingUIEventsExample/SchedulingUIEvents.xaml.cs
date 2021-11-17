using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUIEventsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulingUIEvents : ContentView
    {
        public SchedulingUIEvents()
        {
            InitializeComponent();

            var date = DateTime.Today;
            calendar.AppointmentsSource = new ObservableCollection<Appointment> {
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
                    Color = Color.Orange,
                    IsAllDay = true
                },
                    new Appointment {
                    Title = "Football Game",
                    StartDate = date.AddDays(2).AddHours(15),
                    EndDate = date.AddDays(2).AddHours(17),
                    Color = Color.Green
                },
                new Appointment
                {
                    Title = "Daily Meeting",
                    StartDate = date.AddDays(1).AddHours(9),
                    EndDate = date.AddDays(1).AddHours(9).AddMinutes(15),
                    Color = Color.Red,
                    RecurrenceRule = new RecurrenceRule(new RecurrencePattern()
                    {
                        Frequency = RecurrenceFrequency.Daily,
                        DaysOfWeekMask = RecurrenceDays.EveryDay,
                        MaxOccurrences = 3
                    })
                }
            };
        }

        // >> calendar-schedulingui-events-handlers
        private void CalendarAppointmentAdded(object sender, AppointmentChangedEventAgrs e)
        {
            Application.Current.MainPage.DisplayAlert("Appointment Change", String.Format("Appointment with title `{0}` was created.", e.Appointment.Title), "OK");
        }

        private void CalendarAppointmentUpdated(object sender, AppointmentChangedEventAgrs e)
        {
            string notification;
            switch(e.OccurrenceAction)
            {
                case OccurrenceAction.Add:
                    notification = String.Format("Exception occurence on {0:d} of the recurrent Appointment `{1}` was created.", e.Occurrence.ExceptionDate, e.Appointment.Title);
                    break;
                case OccurrenceAction.Update:
                    notification = String.Format("Exception occurence on {0:d} of the recurrent Appointment `{1}` was updated.", e.Occurrence.ExceptionDate, e.Appointment.Title);
                    break;
                case OccurrenceAction.Delete:
                    notification = String.Format("The occurence on {0:d} of the recurrent Appointment `{1}` was deleted.", e.Occurrence.ExceptionDate, e.Appointment.Title);
                    break;
                default:
                    notification = String.Format("Appointment `{0}` was updated", e.Appointment.Title);
                    break;
            }
            Application.Current.MainPage.DisplayAlert("Appointment Change", notification, "OK");
        }

        private void CalendarAppointmentDeleted(object sender, AppointmentChangedEventAgrs e)
        {
            Application.Current.MainPage.DisplayAlert("Appointment Change", String.Format("Appointment with title `{0}` was deleted.", e.Appointment.Title), "OK");
        }
        // << calendar-schedulingui-events-handlers

    }
}