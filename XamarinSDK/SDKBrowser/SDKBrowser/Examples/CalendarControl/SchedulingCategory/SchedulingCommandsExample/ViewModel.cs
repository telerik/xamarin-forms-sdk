using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.Input.Calendar.Commands;

namespace SDKBrowser.Examples.CalendarControl.SchedulingCategory.SchedulingCommandsExample
{
    // >> calendar-scheduling-commands-vm
    public class ViewModel
    {
        public ViewModel()
        {
            var date = DateTime.Today;
            this.Appointments = new ObservableCollection<Appointment> {
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
                }
            };

            this.AddNewAppointmentContext = new ShowAddAppointmentViewCommandContext();
            this.AddNewAppointmentContext.StartDate = DateTime.Now;
            this.AddNewAppointmentContext.EndDate = DateTime.Now.AddHours(1);

            this.EditAppointmentContext = new ShowEditAppointmentViewCommandContext();
            this.EditAppointmentContext.Appointment = this.Appointments.FirstOrDefault();
        }

        public ObservableCollection<Appointment> Appointments { get; set; }

        public ShowAddAppointmentViewCommandContext AddNewAppointmentContext { get; set; }

        public ShowEditAppointmentViewCommandContext EditAppointmentContext { get; set; }
    }
    // << calendar-scheduling-commands-vm
}
