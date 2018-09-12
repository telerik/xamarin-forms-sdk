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

            this.Content = calendar;
        }
    }
}

