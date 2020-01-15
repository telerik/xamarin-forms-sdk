using System;
using System.Collections.ObjectModel;
using System.Drawing;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.CalendarAppointmentsExample
{
    // >> calendar-appointments-viewmodel
    public class AppointmentsViewModel
    {
        public AppointmentsViewModel()
        {
            var date = DateTime.Today;
            this.Appointments = new ObservableCollection<Appointment>
            {
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
                        StartDate = date,
                        EndDate = date.AddHours(11),
                        Color = Color.Orange,
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
        public ObservableCollection<Appointment> Appointments { get; set; }
    }
    // << calendar-appointments-viewmodel
}
