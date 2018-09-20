using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CalendarAppointmentTappedExample
{
    public class CalendarAppointmentTapped : ContentView
    {
        public CalendarAppointmentTapped()
        {
            // >> calendar-gettingstarted-appointmentssource-csharp
            var date = new DateTime(2017, 12, 12, 0, 25, 0);

            var calendar = new RadCalendar
            {
                DisplayDate = date,
                AppointmentsSource = new List<Appointment>{
                    new Appointment {
                        Title = "Meeting with Tom",
                        Detail = "Sea Garden",
                        StartDate = date.AddHours(1),
                        EndDate = date.AddHours(2),
                        Color = Color.Tomato
                    },
                    new Appointment {
                        Title = "Lunch with Sara",
                        Detail = "Restaurant",
                        StartDate = date.AddHours(2).AddMinutes(30),
                        EndDate = date.AddHours(3),
                        Color = Color.DarkTurquoise
                    },
                    new Appointment {
                        Title = "Birthday",
                        StartDate = date.AddHours(2).AddMinutes(30),
                        EndDate = date.AddHours(3),
                        IsAllDay = true,
                        Color = Color.Orange
                    },
                     new Appointment {
                        Title = "Football Game",
                        StartDate = date.AddDays(1).AddHours(2).AddMinutes(30),
                        EndDate = date.AddDays(1).AddHours(3),
                        Color = Color.Green
                    }
                }
            };
            // << calendar-gettingstarted-appointmentssource-csharp

            // >> calendar-features-setviewmode-csharp
            calendar.NativeControlLoaded += (sender, e) =>
            {
                calendar.TrySetViewMode(CalendarViewMode.Day);
            };
            // << calendar-features-setviewmode-csharp

            // >> calendar-features-appointmenttapped-csharp
            calendar.AppointmentTapped += (sender, e) =>
            {
                Application.Current.MainPage.DisplayAlert(e.Appointment.Title, e.Appointment.Detail, "OK");
            };
            // << calendar-features-appointmenttapped-csharp
            this.Content = calendar;
        }

        // >> calendar-getting-started-appointment-class
        public class Appointment : IAppointment
        {
            public DateTime StartDate { get; set; }

            public Color Color { get; set; }

            public DateTime EndDate { get; set; }

            public string Title { get; set; }

            public bool IsAllDay { get; set; }

            public string Detail { get; set; }
        }
        // << calendar-getting-started-appointment-class
    }
}
