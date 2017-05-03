using SDKBrowser.Droid.Calendar.Styling.CustomRenderer;
using SDKBrowser.Examples.Calendar.Styling.CustomRenderer;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// >> calendar-styling-custom-renderers-android-renderer
[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.Droid.Calendar.Styling.CustomRenderer
{
    public class CustomCalendarRenderer : CalendarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<RadCalendar> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                this.Control.CustomizationRule = new CustomizationRule();

                this.Control.CellDecorationsLayer.Color = 
                    Android.Graphics.Color.ParseColor("#0044FF");
            }
        }
    }
}
// << calendar-styling-custom-renderers-android-renderer