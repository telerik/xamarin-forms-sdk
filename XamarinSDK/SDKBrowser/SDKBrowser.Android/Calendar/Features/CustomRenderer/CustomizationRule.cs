using Android.Runtime;
using Com.Telerik.Android.Common;
using Com.Telerik.Widget.Calendar;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SDKBrowser.Droid.Calendar.Features.CustomRenderer
{
    public class CustomizationRule : Java.Lang.Object, IProcedure
    {
        private Java.Util.Calendar calendar = Java.Util.Calendar.Instance;

        public void Apply(Java.Lang.Object p0)
        {
            CalendarDayCell calendarCell = p0.JavaCast<CalendarDayCell>();
            if (calendarCell.CellType != CalendarCellType.Date)
            {
                return;
            }

            calendarCell.SetBackgroundColor(
                Android.Graphics.Color.ParseColor("#F8F8F8"),
                Android.Graphics.Color.ParseColor("#E0E0E0"));

            calendarCell.SetTextColor(
                Android.Graphics.Color.ParseColor("#000000"),
                Android.Graphics.Color.ParseColor("#FFFFFF"));

            calendar.TimeInMillis = calendarCell.Date;

            var weekDay = calendar.Get(Java.Util.CalendarField.DayOfWeek);
            if (weekDay == 1 || weekDay == 7)
            {
                calendarCell.SetBackgroundColor(
                    Android.Graphics.Color.ParseColor("#EEEEEE"),
                    Android.Graphics.Color.ParseColor("#E0E0E0"));

                calendarCell.SetTextColor(
                    Android.Graphics.Color.ParseColor("#999999"),
                    Android.Graphics.Color.ParseColor("#AAAAAA"));
            }

            if (calendar.Get(Java.Util.CalendarField.Date) == Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Date) &&
                calendar.Get(Java.Util.CalendarField.Month) == Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Month) &&
                calendar.Get(Java.Util.CalendarField.Year) == Java.Util.Calendar.Instance.Get(Java.Util.CalendarField.Year))
            {
                calendarCell.BorderColor = Android.Graphics.Color.ParseColor("#00FF44");
                calendarCell.BorderWidth = Forms.Context.ToPixels(2);
                calendarCell.TextPaint.SetTypeface(Android.Graphics.Typeface.Create(calendarCell.TextPaint.Typeface, Android.Graphics.TypefaceStyle.Bold));
            }

            if (calendarCell.Selected)
            {
                calendarCell.Typeface = Android.Graphics.Typeface.Create(calendarCell.TextPaint.Typeface, Android.Graphics.TypefaceStyle.Bold);
            }
        }
    }
}