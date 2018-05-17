using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.CalendarControl.StylingCategory.CellStylingExample
{
    public class CellStyling : ContentView
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
            Color background = default(Color);
            Color selectedCellForegroundColor = default(Color);
            Color todayBorderColor = Color.FromRgb(115, 174, 239);
            double dayNamesFontSize = default(double);
            double fontSize = default(double);
            Thickness todayBorderThickness = default(Thickness);

            switch (Device.RuntimePlatform)
            {
                case "iOS":
                    background = Color.White;
                    selectedCellForegroundColor = Color.White;
                    fontSize = 14;
                    dayNamesFontSize = 14;
                    todayBorderThickness = new Thickness(2);
                    break;
                case "Android":
                    background = Color.White;
                    selectedCellForegroundColor = Color.FromRgb(139, 209, 0);
                    fontSize = 15;
                    dayNamesFontSize = 15;
                    todayBorderThickness = new Thickness(1);
                    break;
                case "UWP":
                    background = Color.FromRgb(30, 30, 30);
                    selectedCellForegroundColor = Color.White;
                    fontSize = 17;
                    dayNamesFontSize = 17;
                    todayBorderThickness = new Thickness(2);
                    break;
            }

            if (cell.Type == CalendarCellType.DayName)
            {
                return new CalendarCellStyle
                {
                    BackgroundColor = Color.LightGray,
                    FontSize = dayNamesFontSize,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromRgb(0, 122, 255)
                };
            }

            var defaultStyle = new CalendarCellStyle
            {
                BackgroundColor = background,
                FontSize = fontSize,
                FontAttributes = FontAttributes.None,
                TextColor = Color.FromRgb(139, 209, 0)
            };

            if (cell is CalendarDayCell dayCell)
            {
                if (dayCell.IsFromCurrentMonth)
                {
                    if (dayCell.IsToday)
                    {
                        defaultStyle.TextColor = Color.FromRgb(0, 122, 255);
                        defaultStyle.FontAttributes = FontAttributes.Bold;
                        defaultStyle.BorderColor = todayBorderColor;
                        defaultStyle.BorderThickness = todayBorderThickness;
                    }
                }
                else
                {
                    if (dayCell.IsToday)
                    {
                        defaultStyle.TextColor = todayBorderColor;
                        defaultStyle.BorderColor = todayBorderColor;
                        defaultStyle.BorderThickness = todayBorderThickness;
                    }
                    else
                    {
                        defaultStyle.TextColor = Color.FromRgb(166, 181, 137);
                    }
                }

                if (dayCell.IsSelected)
                {
                    defaultStyle.TextColor = selectedCellForegroundColor;
                    defaultStyle.BorderColor = Color.FromHex("FF0066CC");
                }

                return defaultStyle;
            }

            return null; // default style
        }
        // << calendar-features-cellstyling-evaluatecellstyle
    }
}
