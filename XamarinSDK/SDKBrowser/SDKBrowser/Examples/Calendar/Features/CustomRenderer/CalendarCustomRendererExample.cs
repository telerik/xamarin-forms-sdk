using SDKBrowser.Examples.Calendar.Features.CustomRenderer;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Calendar
{
    public class CalendarCustomRendererExample : ContentPage
    {
        public CalendarCustomRendererExample()
        {
            Content = new CustomCalendar();
        }
    }
}