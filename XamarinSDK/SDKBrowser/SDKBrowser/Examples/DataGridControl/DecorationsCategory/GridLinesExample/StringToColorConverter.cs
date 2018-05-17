using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DataGridControl.DecorationsCategory.GridLinesExample
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string color = value.ToString();
                switch (color)
                {
                    case nameof(Color.Gray):
                        return Color.Gray;
                    case nameof(Color.Red):
                        return Color.Red;
                    case nameof(Color.Green):
                        return Color.Green;
                }
            }

            return Color.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
