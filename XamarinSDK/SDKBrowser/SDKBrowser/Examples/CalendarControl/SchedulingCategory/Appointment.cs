using System;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory
{
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
