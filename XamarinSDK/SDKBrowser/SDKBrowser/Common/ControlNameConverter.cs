using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Common
{
    public class ControlNameConverter : IValueConverter
    {
        private const string ControlNameSuffix = "Examples";

        public static string Convert(object value)
        {
            string controlName = value as string;

            if (controlName != null && controlName.EndsWith(ControlNameSuffix))
            {
                controlName = controlName.Substring(0, controlName.Length - ControlNameSuffix.Length);
            }

            return controlName;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
