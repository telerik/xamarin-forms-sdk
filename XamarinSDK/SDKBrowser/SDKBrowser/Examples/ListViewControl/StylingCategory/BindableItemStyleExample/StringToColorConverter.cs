using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.BindableItemStyleExample
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Color.Gray;
            }
            var converter = new ColorTypeConverter();
            return converter.ConvertFromInvariantString(value.ToString());
        }
    }
}