using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace SDKBrowser.WinRT
{
    public class AppBarConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string)
            {
                return new Uri(string.Format("ms-appx:///{0}", value));
            }


            return value;
        }

        private void PrimaryCommands_VectorChanged(Windows.Foundation.Collections.IObservableVector<ICommandBarElement> sender, Windows.Foundation.Collections.IVectorChangedEventArgs @event)
        {
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
