using System;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.Calendar
{
    public class CellStyling : ContentPage
    {
        public CellStyling()
        {
            // >> calendar-features-cellstyling-setstyleforcell
            var calendar = new RadCalendar();
            calendar.SetStyleForCell = this.EvaluateCellStyle;
            calendar.GridLinesDisplayMode = DisplayMode.Show;
            calendar.GridLinesColor = Color.Silver;
            calendar.GridLinesWidth = 1;
            // << calendar-features-cellstyling-setstyleforcell

            Content = calendar;
        }

        // >> calendar-features-cellstyling-evaluatecellstyle
        private CalendarCellStyle EvaluateCellStyle(CalendarCell cell)
        {
            var background = Device.OnPlatform(Color.White, Color.White, Color.FromRgb(30, 30, 30));
            var selectedCellForegroundColor = Device.OnPlatform(Color.White, Color.FromRgb(139, 209, 0), Color.White);
            var dayNamesFontSize = Device.OnPlatform(14, 30, 17);
            var fontSize = Device.OnPlatform(14, 30, 17);
            var todayBorderThickness = Device.OnPlatform(new Thickness(2), new Thickness(1), new Thickness(2));
            var todayBorderColor = Color.FromRgb(115, 174, 239);

            if (cell.Type == CalendarCellType.DayName)
            {
                return new CalendarCellStyle
                {
                    BackgroundColor = Color.Transparent,
                    FontSize = dayNamesFontSize,
                    FontWeight = FontWeight.Bold,
                    ForegroundColor = Color.FromRgb(0, 122, 255)
                };
            }

            var defaultStyle = new CalendarCellStyle
            {
                BackgroundColor = background,
                FontSize = fontSize,
                FontWeight = FontWeight.Normal,
                ForegroundColor = Color.FromRgb(139, 209, 0)
            };

            var dayCell = cell as CalendarDayCell;

            if (dayCell != null)
            {
                if (dayCell.IsFromCurrentMonth)
                {
                    if (dayCell.IsToday)
                    {
                        defaultStyle.ForegroundColor = Color.FromRgb(0, 122, 255);
                        defaultStyle.FontWeight = FontWeight.Bold;
                        defaultStyle.BorderColor = todayBorderColor;
                        defaultStyle.BorderThickness = todayBorderThickness;
                    }
                }
                else
                {
                    if (dayCell.IsToday)
                    {
                        defaultStyle.ForegroundColor = todayBorderColor;
                        defaultStyle.BorderColor = todayBorderColor;
                        defaultStyle.BorderThickness = todayBorderThickness;
                    }
                    else
                    {
                        defaultStyle.ForegroundColor = Color.FromRgb(166, 181, 137);
                    }
                }

                if (dayCell.IsSelected)
                {
                    defaultStyle.ForegroundColor = selectedCellForegroundColor;
                    defaultStyle.BorderColor = Color.FromHex("FF0066CC");
                }

                return defaultStyle;
            }

            return null; // default style
        }
        // << calendar-features-cellstyling-evaluatecellstyle
    }
}
