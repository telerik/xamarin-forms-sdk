using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.DayViewStylingExample
{
    public partial class DayViewStyling
    {
        public DayViewStyling()
        {
            this.InitializeComponent();

            var date = new DateTime(2017, 12, 12, 0, 25, 0);

            this.calendar.AppointmentsSource = new List<Appointment>()
            {
                 new Appointment {
                        Title = "Valeria Birthday",
                        StartDate = date.AddHours(1),
                        EndDate = date.AddHours(2),
                        IsAllDay = true
                 },
                 new Appointment {
                        Title = "March Planing",
                        StartDate = date.AddHours(1),
                        EndDate = date.AddHours(2),
                        IsAllDay = true
                 },
                 new Appointment {
                        Title = "Zhhivko Dimitrov's 36th Birthday",
                        StartDate = date.AddHours(1),
                        EndDate = date.AddHours(2),
                        IsAllDay = true
                 },
                 new Appointment {
                        Title = "Job Interview",
                        StartDate = date.AddHours(1),
                        EndDate = date.AddHours(2),
                        Color = Color.FromHex("#30BCFF")
                 },
                 new Appointment {
                        Title = "Lunch with Lucy",
                        StartDate = date.AddHours(2),
                        EndDate = date.AddHours(3),
                        Color = Color.FromHex("#FF5225")
                 },
                 new Appointment {
                        Title = "Project Discussion",
                        Detail = "Xamarin team",
                        StartDate = date.AddHours(3),
                        EndDate = date.AddHours(5),
                        Color = Color.FromHex("#FFC325")
                 },
                 new Appointment {
                        Title = "Dinner at Nikolas",
                        StartDate = date.AddHours(5),
                        EndDate = date.AddHours(6),
                        Color = Color.FromHex("#FF5225")
                 }
            };

            this.calendar.DayViewStyle = new DayViewStyle
            {
                AllDayAreaBackgroundColor = Color.FromHex("#5A73FE"),
                AllDayLabelFontSize = 10,
                AllDayLabelTextColor = Color.White,
                TimelineBackgroundColor = Color.White,
                TimelineLabelsFontSize = 11,
                TimelineLabelsTextColor = Color.FromHex("#DEDEDE"),
                AllDayAppointmentBackgroundColor = Color.FromHex("#F8F8F8"),
                AllDayAppointmentTextColor = Color.Black,
                AllDayAppointmentFontSize = 12,
                AppointmentFontSize = 16,
                AppointmentDetailsFontSize = 13,
                AppointmentTextColor = Color.Black,
                AppointmentDetailsTextColor = Color.FromHex("#BCBCBC")
            };

            this.calendar.DisplayDate = date;

            calendar.NativeControlLoaded += (sender, e) =>
            {
                this.calendar.TrySetViewMode(CalendarViewMode.Day);
            };
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

        private void Change_ViewMode(object sender, EventArgs e)
        {
            if (calendar.ViewMode == CalendarViewMode.Day)
            {
                this.calendar.TrySetViewMode(CalendarViewMode.Month);
            }
            else
            {
                this.calendar.TrySetViewMode(CalendarViewMode.Day);
            }
        }
    }
}