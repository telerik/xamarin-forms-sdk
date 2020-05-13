using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input.Calendar.Commands;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.CommandsCategory.AppointmentTapExample
{
    // >> calendar-commands-appointmenttappedusercommand
    public class AppointmentTapUserCommand : CalendarCommand
    {
        public AppointmentTapUserCommand()
        {
            Id = CommandId.AppointmentTap;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var tappedAppointment = ((AppointmentTapCommandContext)parameter).Appointment;
            Application.Current.MainPage.DisplayAlert("AppointmentTap Command", "Info: " + tappedAppointment.Title, "OK");
        }
    }
    // << calendar-commands-appointmenttappedusercommand
}
