using SDKBrowser.Droid.Calendar.Features.CustomRenderer;
using SDKBrowser.Examples.Calendar.Features.CustomRenderer;
using Telerik.XamarinForms.InputRenderer.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.Droid.Calendar.Features.CustomRenderer
{
    public class CustomCalendarRenderer : CalendarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Telerik.XamarinForms.Input.RadCalendar> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                this.Control.CustomizationRule = new CustomizationRule();

                this.Control.CellDecorationsLayer.Color = Android.Graphics.Color.ParseColor("#0044FF");
            }
        }
    }
}