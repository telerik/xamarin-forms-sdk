using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ListViewControl.StylingCategory.BindableItemStyleExample
{
    public class StringToBorderLocationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Telerik.XamarinForms.Common.Location.None;
            }
            switch (value.ToString())
            {
                case "Bottom": return Telerik.XamarinForms.Common.Location.Bottom;
                case "Top": return Telerik.XamarinForms.Common.Location.Top;
                case "All": return Telerik.XamarinForms.Common.Location.All;
                default: return Telerik.XamarinForms.Common.Location.None;
            }
        }
    }
}
