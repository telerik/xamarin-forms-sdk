using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingUICustomizationExample
{
    // >> schedulingui-custom-appointment-view-model
    public class ViewModel
    {
        private static DateTime CurrentDate = DateTime.Today;

        public ViewModel()
        {
            this.AppointmentsSource = new ObservableCollection<CustomAppointment>()
            {
                new CustomAppointment()
                {
                    Title = "ComboBox API Discussion",
                    StartDate = CurrentDate.AddHours(15),
                    EndDate = CurrentDate.AddHours(16),
                    Color = Color.Blue,
                    Detail = "Let's meed and discuss the current ComboBox API",
                    Owner = "Joann Curtis"
                },

                new CustomAppointment()
                {
                    Title = "Retrospective Meeting",
                    IsAllDay = true,
                    StartDate = CurrentDate,
                    EndDate = CurrentDate,
                    Color = Color.Red,
                    Owner = "Matt Jameson"
                },

                new CustomAppointment()
                {
                    Title = "Pdf Viewer Discussion",
                    StartDate = CurrentDate.AddDays(1),
                    EndDate = CurrentDate.AddDays(1).AddHours(1),
                    Color = Color.Orange,
                    Owner = "John Steven"
                }
            };
        }

        public ObservableCollection<CustomAppointment> AppointmentsSource { get; set; }
    }
    // << schedulingui-custom-appointment-view-model
}
