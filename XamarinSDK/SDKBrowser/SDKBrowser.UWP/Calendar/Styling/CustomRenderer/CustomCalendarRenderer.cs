using SDKBrowser.Examples.Calendar.Styling.CustomRenderer;
using SDKBrowser.UWP.Calendar.Styling.CustomRenderer;
using Telerik.XamarinForms.Input;
using Telerik.XamarinForms.InputRenderer.UWP;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;

// >> calendar-styling-custom-renderers-uwp-renderer
[assembly: ExportRenderer(typeof(CustomCalendar), typeof(CustomCalendarRenderer))]
namespace SDKBrowser.UWP.Calendar.Styling.CustomRenderer
{
    public class CustomCalendarRenderer : CalendarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<RadCalendar> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                var content = Window.Current.Content as Frame;
                var page = content.Content as Page;
                var resources = page.Resources;

                this.Control.NormalCellStyle = 
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["NormalCellContentStyle"],
                    DecorationStyle = (Style)resources["NormalCellDecorationStyle"]
                };

                this.Control.SelectedCellStyle =
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["NormalCellContentStyle"],
                    DecorationStyle = (Style)resources["SelectedCellDecorationStyle"]
                };

                this.Control.AnotherViewCellStyle = 
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["AnotherViewCellContentStyle"],
                    DecorationStyle = (Style)resources["AnotherViewCellDecorationStyle"],
                };

                this.Control.CurrentCellStyle =
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["NormalCellContentStyle"],
                    DecorationStyle = (Style)resources["CurrentCellDecorationStyle"],
                };

                this.Control.HighlightedCellStyle =
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["HighlightedCellContentStyle"],
                    DecorationStyle = (Style)resources["HighlightedCellDecorationStyle"],
                };

                this.Control.DayNameCellStyle =
                    new Telerik.UI.Xaml.Controls.Input.CalendarCellStyle()
                {
                    ContentStyle = (Style)resources["DayNameCellContentStyle"],
                    DecorationStyle = (Style)resources["DayNameCellDecorationStyle"],
                };
            }
        }
    }
}
// << calendar-styling-custom-renderers-uwp-renderer