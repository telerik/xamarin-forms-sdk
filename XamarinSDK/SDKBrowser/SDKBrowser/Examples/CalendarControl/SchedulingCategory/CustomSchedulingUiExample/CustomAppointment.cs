using System;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.CustomSchedulingUiExample
{
    public class CustomAppointment : Appointment
    {
        public CustomAppointment()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
