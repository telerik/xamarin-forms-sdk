using System;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.AgendaViewStylingExample
{
    // >> calendar-agendaview-styleselector
    public class CustomAgendaViewItemStyleSelector : AgendaItemStyleSelector
    {
        private DateTime now;
        public CustomAgendaViewItemStyleSelector()
        {
            this.now = DateTime.Now;
        }

        public AgendaTextItemStyle CurrentMonthStyle { get; set; }
        public AgendaTextItemStyle CurrentMonthWeeksStyle { get; set; }
        public AgendaTextItemStyle TodayStyle { get; set; }
        public AgendaAppointmentItemStyle AllDayAppointmentStyle { get; set; }

        public override AgendaTextItemStyle SelectMonthItemStyle(AgendaMonthItem item)
        {
            if (this.now.Month == item.Date.Month && this.now.Year == item.Date.Year)
            {
                return this.CurrentMonthStyle;
            }

            return null;
        }

        public override AgendaTextItemStyle SelectWeekItemStyle(AgendaWeekItem item)
        {
            if (this.now.Month == item.StartDate.Month && this.now.Year == item.StartDate.Year)
            {
                return this.CurrentMonthWeeksStyle;
            }

            return null;
        }

        public override AgendaTextItemStyle SelectDayItemStyle(AgendaDayItem item)
        {
            if (this.now.Date == item.Date.Date)
            {
                return this.TodayStyle;
            }

            return null;
        }

        public override AgendaAppointmentItemStyle SelectAppointmentItemStyle(AgendaAppointmentItem item)
        {
            if (item.Appointment.IsAllDay)
            {
                return this.AllDayAppointmentStyle;
            }

            return null;
        }
    }
    // << calendar-agendaview-styleselector
}
