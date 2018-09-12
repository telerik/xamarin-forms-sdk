using System;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.AppointmentsStyleExample
{
    public class Appointment : Telerik.XamarinForms.Input.IAppointment
    {
        public DateTime StartDate { get; set; }
        public Xamarin.Forms.Color Color { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public bool IsAllDay { get; set; }
        public string Detail { get; set; }
    }
}
