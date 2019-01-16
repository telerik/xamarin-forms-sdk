using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUIExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulingUI : ContentView
    {
        public SchedulingUI ()
        {
            InitializeComponent ();

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
            // >> calendar-schedulingui-hookevent
            calendar.TimeSlotTapped += CalendarTimeSlotTapped;
            // << calendar-schedulingui-hookevent
        }

        // >> calendar-schedulingui-timeslottappedevent
        private void CalendarTimeSlotTapped(object sender, TimeSlotTapEventArgs e)
        {
            if (e.StartTime.Hour >= 18)
            {
                e.Handled = true;
                Application.Current.MainPage.DisplayAlert("Cannot add appointment", "Adding appointments after 6 PM is not allowed.", "OK");
            }
        }
        // << calendar-schedulingui-timeslottappedevent
    }
}