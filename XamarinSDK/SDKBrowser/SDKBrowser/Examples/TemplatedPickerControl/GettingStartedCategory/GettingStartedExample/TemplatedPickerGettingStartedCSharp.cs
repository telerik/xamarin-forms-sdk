using System;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace SDKBrowser.Examples.TemplatedPickerControl.GettingStartedCategory.GettingStartedExample
{
    public class TemplatedPickerGettingStartedCSharp : ContentView
    {
        public TemplatedPickerGettingStartedCSharp()
        {
            // >> templatedpicker-getting-started-csharp
            RadTemplatedPicker templatedPicker = new RadTemplatedPicker();
            ControlTemplate controlTemplate = new ControlTemplate(typeof(TemplatedPickerCalendar));
            templatedPicker.SelectorTemplate = controlTemplate;
            // << templatedpicker-getting-started-csharp
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(templatedPicker);
            this.Content = stackLayout;
        }
    }

    // >> templatedpicker-getting-started-custom-calendar
    public class TemplatedPickerCalendar : RadCalendar
    {
        public TemplatedPickerCalendar()
        {
            this.SetBinding(RadCalendar.SelectedDateProperty, new Binding("SelectedValue", mode: BindingMode.TwoWay, source: RelativeBindingSource.TemplatedParent));
        }
    }
    // << templatedpicker-getting-started-custom-calendar
}
