using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.CalendarControl.GettingStartedCategory.GettingStartedExample
{
    public class CalendarGettingStartedCSharp : ContentView
    {
        public CalendarGettingStartedCSharp()
        {
            // >> calendar-gettingstarted-csharp
            var calendar = new RadCalendar();
            // << calendar-gettingstarted-csharp

            calendar.DisplayDate = new System.DateTime(1990, 1, 1);
            this.Content = calendar;
        }
    }
}

