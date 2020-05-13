using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.DatePickerControl.GettingStartedCategory.GettingStartedExample
{
    public class DatePickerGettingStartedCSharp : ContentView
    {
        public DatePickerGettingStartedCSharp()
        {
            // >> datepicker-getting-started-csharp
            var datePicker = new RadDatePicker();
            // << datepicker-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(datePicker);
            this.Content = panel;
        }
    }
}
