using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.AppointmentsStyleExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentsStyleXaml : ContentView
    {
        public AppointmentsStyleXaml()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            DateTime firstDay = new DateTime(now.Year, now.Month, 1);

            calendar.AppointmentsSource = new List<Appointment>()
            {
                new Appointment() { StartDate = firstDay.AddDays(10), EndDate = firstDay.AddDays(11).AddTicks(-1), IsAllDay=true, Title = "Mom's Birthday", Color = Color.Blue },
                new Appointment() { StartDate = firstDay.AddDays(13).AddHours(17), EndDate = firstDay.AddDays(13).AddHours(22), Title = "Big Game", Color = Color.Green },
                new Appointment() { StartDate = firstDay.AddDays(13).AddHours(11), EndDate = firstDay.AddDays(13).AddHours(12), Title = "Planning Meeting", Color =  Color.Orange },
                new Appointment() { StartDate = firstDay.AddDays(15).AddHours(20), EndDate = firstDay.AddDays(15).AddHours(23), Title = "Progress Party", Color = Color.Lime },
                new Appointment() { StartDate = firstDay.AddDays(15).AddHours(10), EndDate = firstDay.AddDays(15).AddHours(12), Title = "Meeting with John", Color = Color.Orange }
            };
        }        
    }
}