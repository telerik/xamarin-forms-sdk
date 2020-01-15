using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DateTimePickerControl.GettingStartedCategory.GettingStartedExample
{
    public class DateTimePickerGettingStartedCSharp : ContentView
    {
        public DateTimePickerGettingStartedCSharp()
        {
            // >> datetimepicker-getting-started-csharp
            var dateTimePicker = new RadDateTimePicker();
            // << datetimepicker-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(dateTimePicker);
            this.Content = panel;
        }
    }
}
