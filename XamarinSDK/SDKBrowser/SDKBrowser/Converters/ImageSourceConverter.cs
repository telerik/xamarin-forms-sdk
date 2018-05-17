using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type type, object parameter, CultureInfo culture)
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
                return string.Format("Assets\\{0}", value);
            }

            return value;
        }

        public object ConvertBack(object value, Type type, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
