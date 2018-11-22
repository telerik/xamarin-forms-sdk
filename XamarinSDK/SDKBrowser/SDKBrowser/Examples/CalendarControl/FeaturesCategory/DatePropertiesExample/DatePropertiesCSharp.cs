using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.FeaturesCategory.DatePropertiesExample
{
    public class DatePropertiesCSharp : ContentView
    {
        public DatePropertiesCSharp ()
        {
            // >> calendar-dateproperties-csharp
            var calendar = new RadCalendar();
            calendar.DisplayDate = new DateTime(2018, 10, 18);
            calendar.MinDate = new DateTime(2018, 10, 15);
            calendar.MaxDate = new DateTime(2018, 12, 31);
            calendar.SelectedDate = new DateTime(2018, 10, 24);
            // << calendar-dateproperties-csharp

            this.Content = calendar;
        }
	}
}