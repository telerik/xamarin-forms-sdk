using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.AppointmentsTemplateExample
{
    // >> calendar-appointments-template-viewmodel
    public class AppointmentsTemplateViewModel
    {
        public AppointmentsTemplateViewModel()
        {
            var date = DateTime.Today;
            this.Appointments = new ObservableCollection<Appointment>
            {
                new Appointment{ Title = "Tom Birthday", IsAllDay = true, Color = Color.FromHex("#C1D8FF"), Detail ="Buy present!", StartDate = date, EndDate = date.AddHours(12)},
                new Appointment{ Title = "Lunch with Sara", IsAllDay = false, Color = Color.FromHex("#EDFDE3"), Detail ="Discuss the new marketing strategy", StartDate = date.AddDays(1).AddHours(12), EndDate = date.AddDays(1).AddHours(13).AddMinutes(30)},
                new Appointment{ Title = "Security Training", IsAllDay = false, Color = Color.FromHex("#EDFDE3"), Detail ="Details for the event come here", StartDate = date.AddHours(15), EndDate = date.AddHours(16)},
                new Appointment{ Title = "Elle Birthday", IsAllDay = true, Color = Color.FromHex("#FFF1F9"), Detail ="Buy present!", StartDate = date.AddDays(1), EndDate = date.AddDays(1).AddHours(12)},
                new Appointment{ Title = "One to One Meeting", IsAllDay = false, Color = Color.FromHex("#EBF2FD"), Detail ="Details for the event come here - for example place, participants and add information", StartDate = date.AddHours(16), EndDate = date.AddHours(17)},
                new Appointment{ Title = "Marathon", IsAllDay = false, Color = Color.FromHex("#FDE2AC"), Detail ="Enjoy running", StartDate = date.AddHours(8), EndDate = date.AddHours(11)},
            };
        }
        public ObservableCollection<Appointment> Appointments { get; set; }
    }
    // << calendar-appointments-template-viewmodel
}
