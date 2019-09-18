using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.AppointmentsTemplateExample
{
    // >> calendar-appointments-template-selector-class
    public class DayViewAppointmentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate AllDay { get; set; }
        public DataTemplate NotAllDay { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var appointmentsTemplate = item as Appointment;

            if (appointmentsTemplate.IsAllDay)
            {
                return this.AllDay;
            }
            return this.NotAllDay;
        }
    }
    // << calendar-appointments-template-selector-class
}
