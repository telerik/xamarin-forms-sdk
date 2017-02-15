using SDKBrowser.Examples.Calendar.Features.CustomRenderer;
using SDKBrowser.iOS.Calendar.Features.CustomRenderer;
using Telerik.XamarinForms.InputRenderer.iOS;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.iOS.Calendar.Features.CustomRenderer
{
    public class CustomCalendarRenderer : CalendarRenderer
    {
        protected override CalendarDelegate CreateCalendarDelegateOverride()
        {
            return new CustomCalendarDelegate();
        }
    }
}