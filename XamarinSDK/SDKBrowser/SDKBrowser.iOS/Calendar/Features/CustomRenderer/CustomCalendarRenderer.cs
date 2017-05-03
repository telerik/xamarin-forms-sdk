using SDKBrowser.Examples.Calendar.Styling.CustomRenderer;
using SDKBrowser.iOS.Calendar.Styling.CustomRenderer;
using Telerik.XamarinForms.InputRenderer.iOS;
using Xamarin.Forms;

// >> calendar-styling-custom-renderers-ios-renderer
[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.iOS.Calendar.Styling.CustomRenderer
{
    public class CustomCalendarRenderer : CalendarRenderer
    {
        protected override CalendarDelegate CreateCalendarDelegateOverride()
        {
            return new CustomCalendarDelegate();
        }
    }
}
// << calendar-styling-custom-renderers-ios-renderer