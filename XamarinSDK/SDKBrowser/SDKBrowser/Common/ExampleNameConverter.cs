using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public class ExampleNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var example = value as Example;
            if (example != null)
            {
                return example.Title ?? example.PageName;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
