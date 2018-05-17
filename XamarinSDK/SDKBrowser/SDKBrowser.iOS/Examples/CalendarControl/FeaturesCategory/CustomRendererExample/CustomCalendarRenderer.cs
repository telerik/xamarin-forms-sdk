using SDKBrowser.Examples.CalendarControl.StylingCategory.CustomRendererExample;
using SDKBrowser.iOS.Examples.CalendarControl.StylingCategory.CustomRendererExample;
using Telerik.XamarinForms.InputRenderer.iOS;
using Xamarin.Forms;

// >> calendar-styling-custom-renderers-ios-renderer
[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.iOS.Examples.CalendarControl.StylingCategory.CustomRendererExample
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