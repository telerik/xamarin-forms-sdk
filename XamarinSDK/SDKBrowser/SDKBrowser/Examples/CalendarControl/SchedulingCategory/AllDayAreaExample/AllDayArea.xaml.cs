using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.AllDayAreaExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllDayArea : ContentView
    {
        public AllDayArea()
        {
            InitializeComponent();

            var date = DateTime.Today;           
            calendar.AppointmentsSource = new List<Appointment> {
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
        private void CalendarLoaded(object sender, EventArgs e)
        {
            var calendar = (RadCalendar)sender;
            calendar.TrySetViewMode(CalendarViewMode.MultiDay);
        }
    }
}