using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TimePickerControl.GettingStartedCategory.GettingStartedExample
{
    public class TimePickerGettingStartedCSharp : ContentView
    {
        public TimePickerGettingStartedCSharp()
        {
            // >> timepicker-getting-started-csharp
            var timePicker = new RadTimePicker();
            // << timepicker-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(timePicker);
            this.Content = panel;
        }
    }
}
