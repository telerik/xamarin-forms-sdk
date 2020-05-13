using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TimeSpanPickerControl.GettingStartedCategory.GettingStartedExample
{
    public class TimeSpanPickerGettingStartedCSharp : ContentView
    {
        public TimeSpanPickerGettingStartedCSharp()
        {
            // >> timespanpicker-getting-started-csharp
            var timeSpanPicker = new RadTimeSpanPicker();
            // << timespanpicker-getting-started-csharp
            var panel = new StackLayout();
            panel.Children.Add(timeSpanPicker);
            this.Content = panel;
        }
    }
}
