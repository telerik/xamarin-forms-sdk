using Android.Runtime;
using Com.Telerik.Android.Common;
using Com.Telerik.Widget.Calendar;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SDKBrowser.Droid.Calendar.Styling.CustomRenderer
{
    // >> calendar-styling-custom-renderers-customization-rule
    public class CustomizationRule : Java.Lang.Object, IProcedure
    {
        private Java.Util.Calendar calendar = Java.Util.Calendar.Instance;

        public void Apply(Java.Lang.Object p0)
        {
            if (!(p0 is CalendarDayCell))
            {
                return;
            }

            CalendarDayCell calendarCell = p0.JavaCast<CalendarDayCell>();
            if (calendarCell.CellType != CalendarCellType.Date)
            {
                return;
            }

            calendarCell.SetBackgroundColor(
                Android.Graphics.Color.ParseColor("#F8F8F8"), // used when the cell is enabled
                Android.Graphics.Color.ParseColor("#E0E0E0")); // used when the cell is disabled

            calendarCell.SetTextColor(
                Android.Graphics.Color.ParseColor("#000000"), // used when the cell is enabled
                Android.Graphics.Color.ParseColor("#FFFFFF")); // used when the cell is disabled

            calendar.TimeInMillis = calendarCell.Date;

            var weekDay = calendar.Get(Java.Util.CalendarField.DayOfWeek);
            if (weekDay == 1 || weekDay == 7)
            {
                calendarCell.SetBackgroundColor(
                    Android.Graphics.Color.ParseColor("#EEEEEE"), // used when the cell is enabled
                    Android.Graphics.Color.ParseColor("#E0E0E0")); // used when the cell is disabled

                calendarCell.SetTextColor(
                    Android.Graphics.Color.ParseColor("#999999"), // used when the cell is enabled
                    Android.Graphics.Color.ParseColor("#AAAAAA")); // used when the cell is disabled
            }

            var currentDate = Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Date);
            var currentMoth = Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Month);
            var currentYear = Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Year);

            var boldTypeface = Android.Graphics.Typeface.Create(
                    calendarCell.TextPaint.Typeface, Android.Graphics.TypefaceStyle.Bold);

            if (calendar.Get(Java.Util.CalendarField.Date) == currentDate &&
                calendar.Get(Java.Util.CalendarField.Month) == currentMoth &&
                calendar.Get(Java.Util.CalendarField.Year) == currentYear)
            {
                calendarCell.BorderColor = Android.Graphics.Color.ParseColor("#00FF44");
                calendarCell.BorderWidth = Forms.Context.ToPixels(2);

                calendarCell.Typeface = boldTypeface;
            }

            if (calendarCell.Selected)
            {
                calendarCell.Typeface = boldTypeface;
            }
        }
    }
    // << calendar-styling-custom-renderers-customization-rule
}