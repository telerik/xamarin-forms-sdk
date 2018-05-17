using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.ElementsDisplayModeExample
{
    public class ElementsDisplayMode : ContentView
    {
        public ElementsDisplayMode()
        {
            // >> calendar-styling-elements-display-mode
            var calendar = new RadCalendar();
            calendar.WeekNumbersDisplayMode = DisplayMode.Show;
            calendar.DayNamesDisplayMode = DisplayMode.Hide;
            // << calendar-styling-elements-display-mode

            this.Content = calendar;
        }
    }
}