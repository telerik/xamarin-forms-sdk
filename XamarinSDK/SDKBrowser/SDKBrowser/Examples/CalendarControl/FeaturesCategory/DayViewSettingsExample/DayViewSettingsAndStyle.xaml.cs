using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.DayViewSettingsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayViewSettingsAndStyle : ContentView
    {
        public DayViewSettingsAndStyle()
        {
            InitializeComponent();

            var date = DateTime.Today;
            calendar.AppointmentsSource = new List<Appointment>{
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
                        EndDate = date.AddHours(12),
                        IsAllDay = true                     
                    }                   
                };
        }
    }
}