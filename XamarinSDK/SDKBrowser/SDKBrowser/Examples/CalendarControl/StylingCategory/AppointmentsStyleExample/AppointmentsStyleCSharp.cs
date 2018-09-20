using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.AppointmentsStyleExample
{
    public class AppointmentsStyleCSharp : ContentView
    {
        public AppointmentsStyleCSharp()
        {  
            DateTime now = DateTime.Now;
            DateTime firstDay = new DateTime(now.Year, now.Month, 1);

            var calendar = new RadCalendar();
            calendar.AppointmentsSource = new List<Appointment>()
            {
                new Appointment() { StartDate = firstDay.AddDays(10), EndDate = firstDay.AddDays(11).AddTicks(-1), IsAllDay=true, Title = "Mom's Birthday", Color = Color.Blue },
                new Appointment() { StartDate = firstDay.AddDays(13).AddHours(17), EndDate = firstDay.AddDays(13).AddHours(22), Title = "Big Game", Color = Color.Green },
                new Appointment() { StartDate = firstDay.AddDays(13).AddHours(11), EndDate = firstDay.AddDays(13).AddHours(12), Title = "Planning Meeting", Color =  Color.Orange },
                new Appointment() { StartDate = firstDay.AddDays(15).AddHours(20), EndDate = firstDay.AddDays(15).AddHours(23), Title = "Progress Party", Color = Color.Lime },
                new Appointment() { StartDate = firstDay.AddDays(15).AddHours(10), EndDate = firstDay.AddDays(15).AddHours(12), Title = "Meeting with John", Color = Color.Orange }
            };

            // >> calendar-appointmentsstyle-csharp
            calendar.AppointmentsStyle = new CalendarAppointmentsStyle
            {
                DisplayMode = AppointmentDisplayMode.Shape,
                Padding = new Thickness(5, 25, 5, 5),
                MaxCount = 10,
                Spacing = 1,
                ShapeType = CalendarAppointmentShapeType.Rectangle,
                ShapesHorizontalLocation = HorizontalLocation.Right,
                ShapesVerticalLocation = VerticalLocation.Bottom,
                ShapesOrientation = Orientation.Vertical,
                ShapeSize = new Size(6, 4),
                AllDayShapesDisplayMode = AllDayDisplayMode.Indicator,
                AllDayIndicatorLocation = Location.Top,
                AllDayIndicatorPadding = new Thickness(5, 2),
                AllDayIndicatorWidth = 2,
            };
            // << calendar-appointmentsstyle-csharp

            this.Content = calendar;      
        }
    }
}
