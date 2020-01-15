using System;
using System.Collections.ObjectModel;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.AgendaViewStylingExample
{
    public partial class AgendaViewStyling : ContentView
    {
        public AgendaViewStyling()
        {
            InitializeComponent();

            this.calendar.AppointmentsSource = GenerateAppointments();
        }

        private static ObservableCollection<IAppointment> GenerateAppointments()
        {
            var appointments = new ObservableCollection<IAppointment>()
            {
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(11),
                    EndDate = DateTime.Today.AddHours(11).AddMinutes(15),
                    Title = "Daily SCRUM",
                    Color = Color.FromHex("55A6FF"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-7).AddHours(10),
                    EndDate = DateTime.Today.AddDays(-7).AddHours(11),
                    Title = "Tokyo Deall call",
                    Color = Color.FromHex("FFA200")
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-7).AddHours(16) ,
                    EndDate = DateTime.Today.AddDays(-7).AddHours(17).AddMinutes(30),
                    Title = "Dinner with the Morgans",
                    Color = Color.FromHex("55A6FF"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-4).AddHours(15),
                    EndDate = DateTime.Today.AddDays(-4).AddHours(16).AddMinutes(30),
                    Title = "Theater evening",
                    Color = Color.FromHex("55A6FF"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-3).AddHours(9),
                    EndDate = DateTime.Today.AddDays(-3).AddHours(10),
                    Title = "Conference call with HQ2",
                    Color = Color.FromHex("FFA200"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-4),
                    EndDate = DateTime.Today.AddDays(-2).AddSeconds(1),
                    Title = "Weekend barbecue",
                    Color = Color.FromHex("55A6FF"),
                    IsAllDay= true,
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(-3),
                    EndDate = DateTime.Today.AddDays(-1).AddSeconds(1),
                    Title = "Mountain biking",
                    Color = Color.FromHex("FF9F55"),
                    IsAllDay = true
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(9),
                    EndDate = DateTime.Today.AddHours(10),
                    Title = "Job Interview",
                    Color = Color.FromHex("FFA200"),

                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(10),
                    EndDate = DateTime.Today.AddHours(11),
                    Title = "Tokyo deal call",
                    Color = Color.FromHex("FFA200"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(14),
                    EndDate = DateTime.Today.AddHours(15).AddMinutes(30),
                    Title = "Yachting",
                    Color = Color.FromHex("55A6FF"),
                    IsAllDay = true
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(16),
                    EndDate = DateTime.Today.AddHours(17).AddMinutes(30),
                    Title = "Dinner with the Morgans",
                    Color = Color.FromHex("55A6FF"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(18),
                    EndDate = DateTime.Today.AddHours(19).AddMinutes(30),
                    Title = "Fitness",
                    Color = Color.FromHex("FF9F55"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(20),
                    EndDate = DateTime.Today.AddHours(22),
                    Title = "Watch a movie",
                    Color = Color.FromHex("EE6C4D"),
                    IsAllDay = true
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddHours(20),
                    EndDate = DateTime.Today.AddHours(22),
                    Title = "Date with Candice",
                    Color = Color.FromHex("EE6C4D"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(2).AddHours(18),
                    EndDate = DateTime.Today.AddDays(2).AddHours(19).AddMinutes(30),
                    Title = "Watch your favourite show",
                    Color = Color.FromHex("55A6FF"),
                    IsAllDay = true,
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(2).AddHours(19),
                    EndDate = DateTime.Today.AddDays(2).AddHours(20).AddMinutes(30),
                    Title = "Football",
                    Color = Color.FromHex("FF9F55"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(3).AddHours(10),
                    EndDate = DateTime.Today.AddDays(3).AddHours(11),
                    Title = "Coordination meeting",
                    Color = Color.FromHex("FFA200"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(3).AddHours(15),
                    EndDate = DateTime.Today.AddDays(3).AddHours(16).AddMinutes(30),
                    Title = "Theater evening",
                    Color = Color.FromHex("55A6FF"),
                    IsAllDay = true
                },
                new Appointment()
                {
                     StartDate = DateTime.Today.AddDays(3).AddHours(18),
                     EndDate = DateTime.Today.AddDays(3).AddHours(19).AddMinutes(30),
                    Title = "Table tennis",
                    Color = Color.FromHex("FF9F55"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(4).AddHours(9),
                    EndDate = DateTime.Today.AddDays(4).AddHours(10),
                    Title = "Conference call with HQ2",
                    Color = Color.FromHex("FFA200"),
                },
                new Appointment()
                {
                    StartDate = DateTime.Today.AddDays(5).AddHours(21),
                    EndDate = DateTime.Today.AddDays(5).AddHours(23),
                    Title = "Birthday party",
                    Color = Color.FromHex("EE6C4D"),
                }
            };

            return appointments;
        }
    }
}
