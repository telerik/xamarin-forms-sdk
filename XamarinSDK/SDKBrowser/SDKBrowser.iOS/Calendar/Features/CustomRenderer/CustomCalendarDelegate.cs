using Telerik.XamarinForms.InputRenderer.iOS;
using TelerikUI;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace SDKBrowser.iOS.Calendar.Styling.CustomRenderer
{
    // >> calendar-styling-custom-renderers-custom-delegate
    public class CustomCalendarDelegate : CalendarDelegate
    {
        public override void UpdateVisualsForCell(TKCalendar calendar, TKCalendarCell cell)
        {
            var dayCell = cell as TKCalendarDayCell;

            if (dayCell != null)
            {
                this.SetBordersWidth(dayCell, 0);

                TKCalendarDayState currentMonthState = TKCalendarDayState.CurrentMonth;
                if ((dayCell.State & currentMonthState) == currentMonthState)
                {
                    dayCell.Style.BackgroundColor = Color.FromHex("#F8F8F8").ToUIColor();
                    dayCell.Style.TextColor = Color.FromHex("#000000").ToUIColor();
                }
                else
                {
                    dayCell.Style.BackgroundColor = Color.FromHex("#E0E0E0").ToUIColor();
                    dayCell.Style.TextColor = Color.FromHex("#FFFFFF").ToUIColor();
                }

                TKCalendarDayState weekendState = TKCalendarDayState.Weekend;
                if ((dayCell.State & weekendState) == weekendState)
                {
                    if ((dayCell.State & currentMonthState) == currentMonthState)
                    {
                        dayCell.Style.BackgroundColor = Color.FromHex("#EEEEEE").ToUIColor();
                        dayCell.Style.TextColor = Color.FromHex("#999999").ToUIColor();
                    }
                    else
                    {
                        dayCell.Style.BackgroundColor = Color.FromHex("#D0D0D0").ToUIColor();
                        dayCell.Style.TextColor = Color.FromHex("#AAAAAA").ToUIColor();
                    }
                }

                TKCalendarDayState todayState = TKCalendarDayState.Today;
                if ((dayCell.State & todayState) == todayState)
                {
                    var borderColor = Color.FromHex("#00FF44");

                    dayCell.Style.ShapeFill = null;

                    this.SetBordersColor(dayCell, borderColor);
                    this.SetBordersWidth(dayCell, 2);
                }

                TKCalendarDayState selectedState = TKCalendarDayState.Selected;
                if ((dayCell.State & selectedState) == selectedState)
                {
                    var borderColor = Color.FromHex("#0044FF");

                    dayCell.Style.ShapeFill = null;

                    this.SetBordersColor(dayCell, borderColor);
                    this.SetBordersWidth(dayCell, 2);
                }
            }
        }

        private void SetBordersWidth(TKCalendarDayCell cell, int width)
        {
            cell.Style.TopBorderWidth = width;
            cell.Style.LeftBorderWidth = width;
            cell.Style.RightBorderWidth = width;
            cell.Style.BottomBorderWidth = width;
        }

        private void SetBordersColor(TKCalendarDayCell cell, Color color)
        {
            var uiColor = color.ToUIColor();

            cell.Style.TopBorderColor = uiColor;
            cell.Style.LeftBorderColor = uiColor;
            cell.Style.RightBorderColor = uiColor;
            cell.Style.BottomBorderColor = uiColor;
        }
    }
    // << calendar-styling-custom-renderers-custom-delegate
}