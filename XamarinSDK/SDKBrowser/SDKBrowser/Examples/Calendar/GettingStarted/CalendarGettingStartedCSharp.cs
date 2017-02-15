using Xamarin.Forms;
using Telerik.XamarinForms.Input;

namespace SDKBrowser.Examples.Calendar
{
    public class CalendarGettingStartedCSharp : ContentPage
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

