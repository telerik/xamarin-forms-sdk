using System;
using System.Globalization;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ComboBoxControl.HowToCategory.DropDownClearButtonExample
{
    // >> combobox-selecteditem-to-color-converter
    public class SelectedItemToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isUWP = Device.RuntimePlatform == Device.UWP;
            return value == null 
                ? isUWP ? Color.Accent : Color.FromHex("#F8F8F8") 
                : isUWP ? Color.FromHex("#F2F2F2") : Color.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    // << combobox-selecteditem-to-color-converter
}
