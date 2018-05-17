using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.FeaturesCategory.DataOperationsExample
{
    public class GroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "group " + value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
