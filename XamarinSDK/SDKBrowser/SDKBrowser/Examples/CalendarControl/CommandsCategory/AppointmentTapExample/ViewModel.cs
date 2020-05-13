using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.Calendar.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.CommandsCategory.AppointmentTapExample
{
    // >> calendar-commands-appointmenttap-viewmodel
    public class ViewModel
    {
        public ViewModel()
        {
            var date = new DateTime(2020,03,24);
            this.Appointments = new ObservableCollection<Appointment>
            {
                new Appointment {
                    Title = "Meeting with Tom",
                    Detail = "Sea Garden",
                    StartDate = date.AddHours(10),
                    EndDate = date.AddHours(11),
                    Color = Color.Tomato
                },
                new Appointment {
                    Title = "Lunch with Sara",
                    Detail = "Restaurant",
                    StartDate = date.AddHours(12).AddMinutes(30),
                    EndDate = date.AddHours(14),
                    Color = Color.DarkTurquoise
                },
                new Appointment {
                    Title = "Elle Birthday",
                    StartDate = date.AddDays(1),
                    EndDate = date.AddDays(1).AddHours(12),
                    IsAllDay = true
                },
                new Appointment {
                    Title = "Football Game",
                    StartDate = date.AddDays(2).AddHours(15),
                    EndDate = date.AddDays(2).AddHours(17),
                    Color = Color.Green
                }
            };
        }

        public ObservableCollection<Appointment> Appointments { get; set; }
    }
    // << calendar-commands-appointmenttap-viewmodel
}
