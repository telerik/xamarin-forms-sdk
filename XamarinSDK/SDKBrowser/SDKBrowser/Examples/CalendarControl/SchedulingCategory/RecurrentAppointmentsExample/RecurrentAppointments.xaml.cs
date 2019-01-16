using System;
using System.Collections.Generic;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.RecurrentAppointmentsExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecurrentAppointments : ContentView
    {
        public RecurrentAppointments ()
        {
            InitializeComponent ();

            // >> calendar-recurrentappts-createappt
            var date = DateTime.Today;
            var appointment = new Appointment()
            {
                Title = "Daily appointment",
                StartDate = date.AddHours(11),
                EndDate = date.AddHours(11).AddMinutes(30), 
                Color = Color.Tomato
            };
            // << calendar-recurrentappts-createappt
            // >> calendar-recurrentappts-recurrencepattern
            var pattern = new RecurrencePattern()
            {
                Frequency = RecurrenceFrequency.Daily,
                DaysOfWeekMask = RecurrenceDays.EveryDay,
                MaxOccurrences = 5
            };
            // << calendar-recurrentappts-recurrencepattern
            // >> calendar-recurrentappts-setrule
            appointment.RecurrenceRule = new RecurrenceRule(pattern);
            // << calendar-recurrentappts-setrule
            // >> calendar-recurrentappts-exceptiondate
            appointment.RecurrenceRule.Exceptions.Add(new ExceptionOccurrence() { ExceptionDate = date.AddDays(1) });
            // << calendar-recurrentappts-exceptiondate
            // >> calendar-recurrentappts-exceptionappt
            var exceptionAppointment = new Appointment()
            {
                Title = appointment.Title,
                StartDate = appointment.StartDate.AddDays(3).AddHours(1),
                EndDate = appointment.EndDate.AddDays(3).AddHours(1),
                Color = appointment.Color
            };
            appointment.RecurrenceRule.Exceptions.Add(new ExceptionOccurrence() {
                                                          ExceptionDate = date.AddDays(3),
                                                          Appointment = exceptionAppointment
                                                     });
            // << calendar-recurrentappts-exceptionappt
            calendar.DisplayDate = date;
            calendar.AppointmentsSource = new List<Appointment> { appointment };
        }
    }
}