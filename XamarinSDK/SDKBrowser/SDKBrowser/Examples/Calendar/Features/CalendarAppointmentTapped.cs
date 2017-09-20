using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Calendar
{
    public class CalendarAppointmentTapped : ContentPage
    {
        public CalendarAppointmentTapped()
        {
            var date = new DateTime(2017, 4, 12);

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
                        IsAllDay = true
                    }
                }
            };

            calendar.NativeControlLoaded += (sender, e) =>
            {
                calendar.TrySetViewMode(CalendarViewMode.Day);
            };

            calendar.AppointmentTapped += (sender, e) =>
            {
                DisplayAlert(e.Appointment.Title, e.Appointment.Detail, "OK");
            };

            this.Content = calendar;
        }

        public class Appointment : IAppointment
        {
            public DateTime StartDate { get; set; }

            public Color Color { get; set; }

            public DateTime EndDate { get; set; }

            public string Title { get; set; }

            public bool IsAllDay { get; set; }

            public string Detail { get; set; }
        }
    }
}
