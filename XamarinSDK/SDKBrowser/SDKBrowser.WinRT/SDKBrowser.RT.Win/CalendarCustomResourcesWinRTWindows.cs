using Telerik.XamarinForms.Common;
using Xamarin.Forms;
using XFExamples.Common.ViewModels;
using XFExamples.WinRT;

namespace SDKBrowser.WinRT
{
    public class CalendarCustomResourcesWinRTWindows: CalendarCustomResources
    {
        private CalendarCustomResourcesWinRTWindows()
        {
        }

		public static void Load()
		{
            if (App.Current.RequestedTheme == Windows.UI.Xaml.ApplicationTheme.Dark)
            {
                SelectedCellForegroundColor = Color.White;
            }
            else
            {
                SelectedCellForegroundColor = Color.FromHex("FF0066CC");
            }

            Background = Color.FromRgb(30, 30, 30);
            DayNamesFontSize = 17;
			WeekNumbersFontSize = 20;
			GridLinesDisplayMode = DisplayMode.Hide;
			BorderThickness = new Thickness(0, 0, 0, 1);
			FontSize = 30;
		}
    }
}
